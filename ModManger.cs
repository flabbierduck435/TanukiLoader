using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using TanukiLoader;
using UnityEngine;

public class ModManger
{
    private static ModManger instance;

    private ICollection<mod> Mods;
    private ModManger()
    {
        Mods = new List<mod>();
    }

    public ICollection<mod> mods()
    {
        return Mods;
    }

    public static ModManger Instance()
    {
        if (instance == null)
        {
            instance = new ModManger();
        }
        return instance;
    }

    public void loadAssemblies(GameObject doorstepGameObject)
    {
        DirectoryInfo dir = new DirectoryInfo(BepInEx.Paths.GameRootPath + "/mods");
        Console.WriteLine("Getting Mods at " + dir.FullName);

        ICollection<Assembly> assemblies = new List<Assembly>();
        foreach (FileInfo dllFile in dir.GetFiles("*.dll"))
        {
            Console.WriteLine("Loading " + dllFile);
            AssemblyName an = AssemblyName.GetAssemblyName(dllFile.FullName);
            Assembly assembly = Assembly.Load(an);
            assemblies.Add(assembly);
            Console.WriteLine("loaded " + dllFile);

        }

        Type ModType = typeof(mod);
        ICollection<Type>ModTypes = new List<Type>();
        foreach (Assembly assembly in assemblies)
        {
            if (assembly != null)
            {
                Type[] types = assembly.GetTypes();
                foreach (Type type in types)
                {
                    if (type.IsInterface || type.IsAbstract)
                    {
                        continue;
                    }
                    else
                    {
                        if (type.GetInterface(ModType.FullName) != null)
                        {
                            ModTypes.Add(type);
                        }
                    }
                }
            }
        }

        // initialize the plugins and start them from the unity-context
        foreach (Type type in ModTypes)
        {
            mod mod = (mod)Activator.CreateInstance(type);
            Mods.Add(mod);
            mod.initialize();
            mod.start(doorstepGameObject);
        }


    }
}

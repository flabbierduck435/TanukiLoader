using BepInEx;
using System.Threading;
using UnityEngine;

namespace TanukiLoader
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private GameObject OBJ;
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            new Thread(() =>
            {
                // wait a short amount of time in order to let the game initialize itself
                Thread.Sleep(2500);

                OBJ = new GameObject("TanukiPlugin");
                UnityEngine.Object.DontDestroyOnLoad(OBJ);
                ModManger manger = ModManger.Instance();
                manger.loadAssemblies(OBJ);
            }).Start();
        }
    }
}

# TanukiLoader
 Mod Loader For Tanuki Sunset

this is based off of the **[sheltered mod manager](https://github.com/benjaminfoo/shelteredmodmanager)**

# How to use

#### Unstriping the game
tools needed

**[BepInEx5](https://github.com/BepInEx/BepInEx/releases/tag/v5.4.23.2)**

**[AssetRipper](https://github.com/AssetRipper/AssetRipper/releases/tag/1.0.18)**

**[unity 2018.4.13](https://unity.com/releases/editor/whats-new/2018.4.13)**

**[Steamworks.NET](https://github.com/rlabrecque/Steamworks.NET/releases/download/14.0.0/Steamworks.NET_14.0.0.unitypackage)**

1. open AssetRipper and open the Tanuki sunset Data folder

2. click export and export all files, then pick a folder and the export

3. when it is done exporting make sure to go in the ExportedProject\Assets\Scenes folder and remove the Store folder(if this is not removed the unity will crash)

4. now add the ExportedProject folder to unity and open the project(This may take a long time)

5. now in unity remove the following folder Plugins\Assembly-CSharp-firstpass\Steamworks

6. drag the Steamworks.NET 14 onto unity

7. remove the Scripts\Steamworks.NET\SteamManager.cs (after this unity should take a bit to load all the scripts)

8. now just make sure that the folder in step 3 is still gone(it sometimes comes back)

9. now click file -> build settings -> build. (you may get a popup just click yes)

10. now go to the build and open the data folder

11. move the Managed to real tanukisunset Data folder and replace all

#### installing TanukiLoader

1. take the BepInEx5 and putin the root of TanukiSunset

2. Make a BepInEx\plugins folder at the root

3. unzip TanukiLoader in the plugins folder

#### installing mods

1. Make a mods folder at the root of TanukiSunset

2. put the dll of the mod in the mods folder

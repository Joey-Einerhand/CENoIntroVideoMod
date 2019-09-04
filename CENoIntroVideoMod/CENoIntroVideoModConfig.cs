using System;
using UModFramework.API;

namespace CENoIntroVideoMod
{
    public class CENoIntroVideoModConfig
    {
        private static readonly string configVersion = "1.0.1";

        //Add your config vars here.


        internal static void Load()
        {
            CENoIntroVideoMod.Log("Loading settings.");
            try
            {
                using (UMFConfig cfg = new UMFConfig())
                {
                    string cfgVer = cfg.Read("ConfigVersion", new UMFConfigString());
                    if (cfgVer != string.Empty && cfgVer != configVersion)
                    {
                        cfg.DeleteConfig(false);
                        CENoIntroVideoMod.Log("The config file was outdated and has been deleted. A new config will be generated.");
                    }

                    //cfg.Write("SupportsHotLoading", new UMFConfigBool(false)); //Uncomment if your mod can't be loaded once the game has started.
                    //cfg.Write("ModDependencies", new UMFConfigStringArray(new string[] { "" })); //A comma separated list of mod names that this mod requires to function.
                    //cfg.Write("ModDependenciesVersions", new UMFConfigStringArray(new string[] { "" })); //A comma separated list of mod versions matching the ModDependencies setting.
                    cfg.Read("LoadPriority", new UMFConfigString("Normal"));
                    cfg.Write("MinVersion", new UMFConfigString("0.52.1"));
                    //cfg.Write("MaxVersion", new UMFConfigString("0.54.99999.99999")); //Uncomment if you think your mod may break with the next major UMF release.
                    cfg.Write("UpdateURL", new UMFConfigString(""));
                    cfg.Write("ConfigVersion", new UMFConfigString(configVersion));

                    CENoIntroVideoMod.Log("Finished UMF Settings.");

                    //Add your settings here

                    CENoIntroVideoMod.Log("Finished loading settings.");
                }
            }
            catch (Exception e)
            {
                CENoIntroVideoMod.Log("Error loading mod settings: " + e.Message + "(" + e.InnerException?.Message + ")");
            }
        }
    }
}
using UnityEngine;
using UModFramework.API;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CENoIntroVideoMod
{
    [UMFHarmony(1)] //Set this to the number of harmony patches in your mod.
    [UMFScript]
    class CENoIntroVideoMod : MonoBehaviour
    {
        internal static void Log(string text, bool clean = false)
        {
            using (UMFLog log = new UMFLog()) log.Log(text, clean);
        }

        [UMFConfig]
        public static void LoadConfig()
        {
            CENoIntroVideoModConfig.Load();
        }

		void Awake()
		{
			Log("CENoIntroVideoMod v" + UMFMod.GetModVersion().ToString(), true);
		}

        void Update()
        {
        }
	}
}
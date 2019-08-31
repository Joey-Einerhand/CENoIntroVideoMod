using UnityEngine;
using HarmonyLib;

namespace CENoIntroVideoMod.Patches
{
    [HarmonyPatch(typeof(CLASSTOPATCH))]
    [HarmonyPatch("FUNCTIONTOPATCH")]
    static class Patch_PURPOSEOFPATCH
    {
        //1. Change CLASSTOPATCH to the class you are modifying/overwriting.
        //2. Change FUNCTIONTOPATCH to the function/method you are modifying/overwriting.
        //3. Rename the PURPOSEOFPATCH.cs file and class to the purpose of your patch.
        //4. Add your harmony postfix, prefix or transpiler here.
    }
}
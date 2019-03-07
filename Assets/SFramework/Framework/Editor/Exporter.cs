using System;
using System.IO;
using UnityEngine;
using UnityEditor;


namespace SFramework
{
    public partial class Exporter
    {
        [MenuItem("SFramework/Framework/Editor/导出 UnityPackage %e", false,1)]
        private static void MenuClicked()
        {
            var generatePackageName = GenerateUnityPackageName();

            EditorUtil.ExportPackage("Assets/SFramework", generatePackageName + ".unitypackage");
            EditorUtil.OpenInFolder(Path.Combine(Application.dataPath, "../"));
        }
        public static string GenerateUnityPackageName()
        {
            return "SFramework_" + DateTime.Now.ToString("yyyyMMdd_hh");
        }
    }
}



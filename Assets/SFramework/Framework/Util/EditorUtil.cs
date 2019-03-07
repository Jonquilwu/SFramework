using UnityEngine;

namespace SFramework
{
    public partial class EditorUtil
    {
        public static void OpenInFolder(string folderPath)
        {
            Application.OpenURL("file:///" + folderPath);
        }
#if UNITY_EDITOR
        public static void CallMenuItem(string menuPath)
        {
            UnityEditor.EditorApplication.ExecuteMenuItem(menuPath);
        }

        public static void ExportPackage(string assetPathName, string fileName)
        {
            UnityEditor.AssetDatabase.ExportPackage(assetPathName, fileName, UnityEditor.ExportPackageOptions.Recurse);
        }
#endif
    }
}


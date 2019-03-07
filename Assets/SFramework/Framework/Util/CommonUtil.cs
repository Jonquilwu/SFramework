using UnityEngine;

namespace SFramework
{
    public partial class CommonUtil
    {
        public static void CopyText(string text)
        {
            GUIUtility.systemCopyBuffer = text;
        }
    }
}


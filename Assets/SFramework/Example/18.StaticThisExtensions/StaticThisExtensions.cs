using UnityEngine;

namespace SFramework
{
    public static class StaticThisExtensions
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("SFramework/Example/18.StaticThisExtension", false, 18)]
#endif
        static void MenuClicked()
        {
            new object().Test();
            "string".Test();
        }

        static void Test(this object selfObj)
        {
            Debug.Log(selfObj);
        }
    }
}


using UnityEngine;

namespace SFramework
{
    public class CommonUtilExample : MonoBehaviour
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("SFramework/Example/1.复制文本到剪切板",false,2)]
#endif
        private static void MenuClicked()
        {
            CommonUtil.CopyText("要复制的关键字");
        }
    }
}


namespace SFramework
{
    public class EditorUtilExample
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("SFramework/Example/2.MenuItem 复用", false, 2)]
        private static void MenuClicked()
        {
            EditorUtil.CallMenuItem("SFramework/Example/1.复制文本到剪切板");
        }
#endif
    }
}


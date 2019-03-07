using UnityEngine;

namespace SFramework
{
    public class HideExample
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("SFramework/Example/7.Hide 脚本", false, 8)]
        private static void MenuClicked()
        {
            UnityEditor.EditorApplication.isPlaying = true;

            var gameObj = new GameObject("Hide");
            gameObj.AddComponent<Hide>();
        }
#endif
    }
}


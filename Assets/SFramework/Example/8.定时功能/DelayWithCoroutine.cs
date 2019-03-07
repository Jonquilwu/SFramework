using UnityEngine;

namespace SFramework
{
    public class DelayWithCoroutine : MonoBehaviourSimplify
    {
        private void Start()
        {
            Delay(5.0f, () =>
            {
                UnityEditor.EditorApplication.isPlaying = false;
            });
        }

#if UNITY_EDITOR
        [UnityEditor.MenuItem("SFramework/Example/8.定时功能", false, 9)]
        private static void MenuClicked()
        {
            UnityEditor.EditorApplication.isPlaying = true;

            new GameObject("DelayWithCoroutine").AddComponent<DelayWithCoroutine>();
        }
#endif
        protected override void OnBeforeDestroy()
        {
           
        }
    }
}


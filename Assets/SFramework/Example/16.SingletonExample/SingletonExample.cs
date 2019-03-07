using UnityEngine;

namespace SFramework
{
    public class SingletonExample : Singleton<SingletonExample>
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("SFramework/Example/16.SingleonExample", false, 16)]
        private static void MenuClicked()
        {
            var initInstance = SingletonExample.Instance;
            initInstance = SingletonExample.Instance;
        }
#endif
        private SingletonExample()
        {
            Debug.Log("SingletonExample ctor");
        }
    }
}


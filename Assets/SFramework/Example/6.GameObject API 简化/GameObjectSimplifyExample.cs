using UnityEngine;

namespace SFramework
{
    public class GameObjectSimplifyExample
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("SFramework/Example/6.GameObject API 简化", false, 7)]
#endif
        private static void MenuClicked()
        {
            //var gameObject = new GameObject();
            //GameObjectExtension.Hide(gameObject);
            //GameObjectExtension.Hide(gameObject.transform);
            GameObject gameObject = new GameObject();
            gameObject.Hide();
            gameObject.transform.Hide();
        }
    }
}


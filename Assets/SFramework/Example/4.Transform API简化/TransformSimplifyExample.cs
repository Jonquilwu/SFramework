using UnityEngine;

namespace SFramework
{
    public class TransformSimplifyExample
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("SFramework/Example/4.Transform API简化", false, 5)]
#endif
        private static void MenuClicked()
        {
            //var transform = new GameObject("transform").transform;
            //TransformExtensions.SetLocalPosX(transform, 5.0f);
            //TransformExtensions.SetLocalPosY(transform, 5.0f);
            //TransformExtensions.SetLocalPosZ(transform, 5.0f);
            //TransformExtensions.Identity(transform);

            //var childTrans = new GameObject("Child").transform;
            //TransformExtensions.AddChild(transform, childTrans);

            GameObject gameObject = new GameObject();

            gameObject.transform.SetLocalPosX(5.0f);
            gameObject.transform.SetLocalPosY(5.0f);
            gameObject.transform.SetLocalPosZ(5.0f);

            gameObject.transform.Identity();
        }
    }
}


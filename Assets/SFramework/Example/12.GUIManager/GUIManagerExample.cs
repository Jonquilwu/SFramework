using SFramework;
using UnityEngine;

namespace SFramework { 
}
public class GUIManagerExample : MonoBehaviourSimplify {
#if UNITY_EDITOR
    [UnityEditor.MenuItem("SFramework/Example/12.GUIManager", false, 11)]
    private static void MenuClicked()
    {
        UnityEditor.EditorApplication.isPlaying = true;

        new GameObject("GUIExample").AddComponent<GUIManagerExample>();
    }
#endif

    private void Start()
    {
        GUIManager.SetResolution(1280, 720, 0);

        GUIManager.LoadPanel("HomePanel", UILayer.Common);
        Delay(3.0f, () => 
        {
            GUIManager.UnLoadPanel("HomePanel");
        });      
    }

    protected override void OnBeforeDestroy()
    {
    }
}

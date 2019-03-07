using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SFramework
{
    public class LevelExample : MonoBehaviourSimplify
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("SFramework/Example/15.LevelManager", false,15)]
        private static void MenuClicked()
        {
            UnityEditor.EditorApplication.isPlaying = true;
            new GameObject("LevelExample").AddComponent<LevelExample>();
        }

        private void Start()
        {
            DontDestroyOnLoad(this);

            LevelManager.Init(new List<string>{
                "Home",
                "Level"
            });

            LevelManager.LoadCurrent();
            Delay(10.0f, LevelManager.LoadNext);
        }

        protected override void OnBeforeDestroy()
        {

        }
#endif

    }
}


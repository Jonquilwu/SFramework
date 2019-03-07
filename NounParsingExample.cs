using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SFramework
{
    /// <summary>
    /// GameObject gameObject Transform tansform的区别
    /// </summary>
    public partial class NounParsingExample : MonoBehaviour
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("SFramework/Example/19.GameObject相关概念解析", false, 19)]
        private static void MenuClicked()
        {
            UnityEditor.EditorApplication.isPlaying = true;
            new GameObject("GameOvject").AddComponent<NounParsingExample>();
        }
#endif

        private GameObject m_gameObject;
        private Transform m_transform;

        void Start()
        {
            m_gameObject = this.gameObject;
            m_transform = this.transform;

            print("gameObject.name ==>" + m_gameObject.name);
            print("transform.gameObject.name ==>" + m_transform.gameObject.name);
            print("gameObject.transform.gameObject.name ==>" + m_gameObject.transform.gameObject.name);
            print("——————————————————————————————————分割线——————————————————————————————————");
            print("transform.name ==>" + m_transform.name);
            print("gameOjbect.transform.name ==>" + m_gameObject.transform.name);
            print("transform.gameObject.transform.name ==> " + m_transform.gameObject.transform.name);
            string content = "亦郁啊";
            Text text = m_gameObject.AddComponent<Text>();
            text.text = content;
            Debug.Log("Text:" + text.text);
        }

    }
}


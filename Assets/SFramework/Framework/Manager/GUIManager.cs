using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SFramework
{
    public enum UILayer
    {
        Bg,
        Common,
        Top
    }

    public class GUIManager
    {
        private static GameObject mPrivateUIRoot;
        public static GameObject UIRoot
        {
            get
            {
                if (mPrivateUIRoot == null)
                {
                    mPrivateUIRoot = Object.Instantiate(Resources.Load<GameObject>("UIRoot"));
                    mPrivateUIRoot.name = "UIRoot";                 
                }
                return mPrivateUIRoot;
            }
        }

        private static Dictionary<string, GameObject> mPanelDict = new Dictionary<string, GameObject>();

        public static void SetResolution(float width, float height, float matchWidthOrHeight)
        {
            var canvasScaler = UIRoot.GetComponent<CanvasScaler>();
            canvasScaler.referenceResolution = new Vector2(width, height);
            canvasScaler.matchWidthOrHeight = matchWidthOrHeight;
        }

        public static void UnLoadPanel(string panelName)
        {
            if (mPanelDict.ContainsKey(panelName))
            {
                Object.Destroy(mPanelDict[panelName]);
            }
        }

        public static GameObject LoadPanel(string panelName, UILayer layer)
        {
            var panelPrefab = Resources.Load<GameObject>(panelName);
            var panel = GameObject.Instantiate(panelPrefab);
            panel.name = panelName;

            mPanelDict.Add(panelName, panel);

            switch (layer)
            {
                case UILayer.Bg:
                    panel.transform.SetParent(UIRoot.transform.Find("Bg"));
                    break;
                case UILayer.Common:
                    panel.transform.SetParent(UIRoot.transform.Find("Common"));
                    break;
                case UILayer.Top:
                    panel.transform.SetParent(UIRoot.transform.Find("Top"));
                    break;
            }
           

            var panelRectTrans = panel.transform as RectTransform;
            panelRectTrans.offsetMin = Vector2.zero;
            panelRectTrans.offsetMax = Vector2.zero;
            panelRectTrans.anchoredPosition3D = Vector3.zero;
            panelRectTrans.anchorMax = Vector2.one;
            panelRectTrans.anchorMin = Vector2.zero;

            panelRectTrans.localScale = Vector3.one;

            return panel;
        }
    }
}


using UnityEngine;

namespace SFramework
{
    public class ResolutionCheckExample
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("SFramework/Example/3.屏幕宽高比判断",false, 3)]
#endif
        private static void MenuClicked()
        {
            Debug.Log(ResolutionCheck.IsPadResolution() ? "是 Pad 分辨率" : "不是 Pad 分辨率");
            Debug.Log(ResolutionCheck.IsPhoneResolution() ? "是 Phone 分辨率" : "不是 Phone 分辨率");
            Debug.Log(ResolutionCheck.IsiPhoneXResolution() ? "是 iPhoneX 分辨率" : "不是 iPhoneX 分辨率");
        }
    }
}


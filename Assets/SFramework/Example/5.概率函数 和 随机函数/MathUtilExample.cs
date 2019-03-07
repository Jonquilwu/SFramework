using UnityEngine;

namespace SFramework
{
    public class MathUtilExample : MonoBehaviour
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("SFramework/Example/5.概率函数 和 随机函数", false, 6)]
#endif
        private static void MenuClicked()
        {
            Debug.Log(MathUtil.Percent(50));

            Debug.Log(MathUtil.GetRandomValueFrom(1, 2, 3));
            Debug.Log(MathUtil.GetRandomValueFrom("asdasf", "das", "123"));
            Debug.Log(MathUtil.GetRandomValueFrom(0.1f, 0.2f, 0.3f));
        }
    }
}


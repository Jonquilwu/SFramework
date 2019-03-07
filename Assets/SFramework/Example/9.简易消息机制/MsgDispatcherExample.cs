﻿using UnityEngine;

namespace SFramework
{
    public class MsgDispatcherExample : MonoBehaviour
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("SFramework/Example/9.消息简易机制", false, 10)]
#endif
        private static void MenuClicked()
        {
            //全部清空，确保测试有效
            MsgDispatcher.UnRegisterAll("消息1");

            MsgDispatcher.Register("消息1", OnMsgReceived);
            MsgDispatcher.Register("消息1", OnMsgReceived);

            MsgDispatcher.Send("消息1", "hello work");

            MsgDispatcher.UnRegister("消息1", OnMsgReceived);

            MsgDispatcher.Send("消息1", "hello");
        }

        private static void OnMsgReceived(object data)
        {
            Debug.LogFormat("消息1：{0}", data);
        }
    }
}


﻿using SFramework;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class GameModule : MainManager
    {
        public static void LoadModule()
        {
            SceneManager.LoadScene("Game");
        }

        protected override void LaunchInDevelopingMode()
        {
            //开发逻辑
            //加载资源
            //初始化 SDK
            //Game 的一些准备逻辑（角色选择、准备一些假的数据等等）
            Debug.Log("开发逻辑");
        }

        protected override void LaunchInProductionMode()
        {
            //正常的 生产逻辑
            Debug.Log("生产逻辑");
        }

        protected override void LaunchInTestMode()
        {
            //正常的 测试逻辑
            Debug.Log("测试逻辑");
        }
    }
}


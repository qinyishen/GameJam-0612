using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CGM
{
    public class CenterGameManager : Singleton<CenterGameManager>
    {
        [Header("我的SceneLoader")]
        public CGM_SceneLoader m_SceneLoader;

        [Header("我的SaveData管理器")]
        public CGM_SaveDataManager m_SaveDataManager;

        [Header("我的UILoader")]
        public CGM_UILoader m_UILoader;

        //游戏状态
        public int State = 0; //0=startScene,1=GameScene,

        // Start is called before the first frame update
        void Start()
        {
            //设置固定帧率
            Application.targetFrameRate = 60;
            DontDestroyOnLoad(this.gameObject);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

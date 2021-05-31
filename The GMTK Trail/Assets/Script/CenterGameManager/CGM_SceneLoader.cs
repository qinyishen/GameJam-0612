using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CGM
{
    public class CGM_SceneLoader : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        /// <summary>
        /// 从0场景加载至Start场景的方法
        /// </summary>
        public void Core_LoadStartScene()
        {
            SceneManager.LoadScene(1);
        }

        /// <summary>
        /// 使用LoadingScene加载场景用
        /// </summary>
        /// <param name="SceneName"></param>
        /// <param name="state">游戏状态,0=startScene,1=GameScene</param>
        public void LoadSceneByString(string SceneName, int state)
        {
            PlayerPrefs.SetString("NextLoadingScene", SceneName);
            PlayerPrefs.SetInt("NextLoadingSceneState", state);
            SceneManager.LoadScene("99LoadingScene");
        }
    }
}

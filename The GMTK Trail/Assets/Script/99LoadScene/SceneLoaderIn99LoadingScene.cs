using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

namespace CGM
{
    public class SceneLoaderIn99LoadingScene : MonoBehaviour
    {
        private AsyncOperation async = null;
        private string nextSceneName;
        private int state;


        //进度条的数值
        private float progressValue;

        private void Start()
        {
            nextSceneName = PlayerPrefs.GetString("NextLoadingScene");
            state = PlayerPrefs.GetInt("NextLoadingSceneState");
            StartCoroutine("LoadScene");
        }


        IEnumerator LoadScene()
        {
            async = SceneManager.LoadSceneAsync(nextSceneName);
            async.allowSceneActivation = false;
            while (!async.isDone)
            {
                if (async.progress < 0.9f)
                    progressValue = async.progress;
                else
                    progressValue = 1.0f;

                if (progressValue >= 0.9)
                {
                    GameObject.FindGameObjectWithTag("CGM").GetComponent<CenterGameManager>().State = state;
                    async.allowSceneActivation = true;
                }
                yield return new WaitForSeconds(2f);
            }
        }

    }
}

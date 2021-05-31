using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CGM;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        CenterGameManager.instance.m_UILoader.ClearAllUI(99);
        CenterGameManager.instance.m_SceneLoader.LoadSceneByString("3GameScene", 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CGM;

public class MakeItToStartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("CGM").GetComponent<CenterGameManager>().m_SceneLoader.Core_LoadStartScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

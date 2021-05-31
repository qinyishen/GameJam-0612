using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System.Collections.Generic;

namespace CGM
{
    public class CGM_GamePlayManager : MonoBehaviour
    {
        [Header("------------------临时参数------------------")]
        public int value1;

        // Start is called before the first frame update
        void Start()
        {
            //初始化DoTween设置
            DOTween.Init(true, true, LogBehaviour.ErrorsOnly).SetCapacity(100, 20);
        }

        // Update is called once per frame
        void Update()
        {

        }

    }
}

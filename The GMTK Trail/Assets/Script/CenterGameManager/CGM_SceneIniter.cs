using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CGM
{
    public class CGM_SceneIniter : MonoBehaviour
    {
        [Header("等着被初始化的UI们")]
        public List<GameObject> UIList_Base;
        public List<GameObject> UIList_Front;
        public List<GameObject> UIList_Confirm;

        private  CenterGameManager  myCGM;

    // Start is called before the first frame update
    void Start()
        {
            myCGM = CenterGameManager.instance;
            if (UIList_Base.Count > 0)
            {
                foreach (var item in UIList_Base)
                {
                    myCGM.m_UILoader.LoadUI(item, 0);
                }
            }
            if (UIList_Front.Count > 0)
            {
                foreach (var item in UIList_Front)
                {
                    myCGM.m_UILoader.LoadUI(item, 1);
                }
            }
            if (UIList_Confirm.Count > 0)
            {
                foreach (var item in UIList_Confirm)
                {
                    myCGM.m_UILoader.LoadUI(item, 2);
                }
            }
        }
    }
}

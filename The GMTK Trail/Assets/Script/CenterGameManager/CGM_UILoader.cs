using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGM_UILoader : MonoBehaviour
{
    public Transform BaseUI;
    public Transform FrontUI;
    public Transform ConfirmUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 添加ui
    /// </summary>
    /// <param name="UI"></param>
    /// <param name="layer">0=base 1=front 2=confirm</param>
    public GameObject LoadUI(GameObject UI,int layer)
    {
        GameObject temp=null;
        switch (layer)
        {
            case 0:
                temp= Instantiate(UI, BaseUI);
                break;
            case 1:
                temp=Instantiate(UI, FrontUI);
                break;
            case 2:
                temp=Instantiate(UI, ConfirmUI);
                break;
            default:
                break;
        }
        return temp;
    }

    /// <summary>
    /// 删除某个层的所有ui
    /// </summary>
    /// <param name="layer">0=base 1=front 2=confirm 99=all</param>
    public void ClearAllUI(int layer)
    {
        switch (layer)
        {
            case 0:
                for (int i = BaseUI.childCount - 1; i >= 0; i--)
                {
                    Destroy(BaseUI.GetChild(i).gameObject);
                }
                break;
            case 1:
                for (int i = FrontUI.childCount - 1; i >= 0; i--)
                {
                    Destroy(FrontUI.GetChild(i).gameObject);
                }
                break;
            case 2:
                for (int i = ConfirmUI.childCount - 1; i >= 0; i--)
                {
                    Destroy(ConfirmUI.GetChild(i).gameObject);
                }
                break;
            case 99:
                for (int i = BaseUI.childCount - 1; i >= 0; i--)
                {
                    Destroy(BaseUI.GetChild(i).gameObject);
                }
                for (int i = FrontUI.childCount - 1; i >= 0; i--)
                {
                    Destroy(FrontUI.GetChild(i).gameObject);
                }
                for (int i = ConfirmUI.childCount - 1; i >= 0; i--)
                {
                    Destroy(ConfirmUI.GetChild(i).gameObject);
                }
                break;
            default:
                break;
        }
    }
}

//using Assets.Script.Data;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


//原本是用来存档时打包保存用的,可以考虑下要不要这么用，如果使用，则每次保存时间变长
public struct GameDate
{

}



public class CGM_SaveDataManager : MonoBehaviour
{
    //Start is called before the first frame update
    void Start()
    {
        //存档文件名设定
        SaveSystem.Initialize("GMTKTrail.bin");
    }


    //------------------------------------------下面是全局的ARG参数----------------------------------------
    public static float JumpForce = 150;
    public static int MaxEnemy = 3;




    //------------------------------------------下面是保存和读取的方法----------------------------------------
    public void SaveGame_CharaState(float hp)
    {
        SaveSystem.SetFloat("Chara1_Hp", hp);
    }

    void OnApplicationQuit()
    {
        SaveSystem.SaveToDisk();
    }
}

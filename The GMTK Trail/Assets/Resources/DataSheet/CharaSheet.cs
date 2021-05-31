using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using geniikw.DataSheetLab;


    [Serializable]
    public class CharactorParameter
    {
        //ID
        public int ID;

        //名字
        public string name;

        //三围
        public float bust;
        public float waist;
        public float hipline;
    }

    /// <summary>
    /// sheet class name must be same with file name.
    /// </summary>
    [CreateAssetMenu]
    public class CharaSheet : Sheet<CharactorParameter> { }
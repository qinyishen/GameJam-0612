using geniikw.DataSheetLab;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.Events;

public class IngameRefer : MonoBehaviour {

    //public CharacterSheet sheet;
    public Dropdown selector;
    public Text Name;
    public Text Attack;

    public IngameSkillRefer prefab;
    public Transform skillPos;

	// Use this for initialization
	void Start () {
        //selector.AddOptions(sheet.data.Select(c => c.name).ToList());
        selector.onValueChanged.AddListener(ChangeHandler);
        ChangeHandler(0);
    }
	
    void ChangeHandler(int idx)
    {
        //ame.text = sheet[idx].name;
        //Attack.text = sheet[idx].attack.ToString();
        
        var skills = FindObjectsOfType<IngameSkillRefer>();
        
        foreach(var skill in skills)
        {
            Destroy(skill.gameObject);
        }
        
        Vector3 p = skillPos.position;

        //use foreach reference all item.
        /*foreach (var skill in sheet[idx].skillSet)
        {
            var sr = Instantiate(prefab) as IngameSkillRefer;
            sr.transform.SetParent(transform);
            sr.SetupSkill(skill);
            sr.transform.position = p;
            p += Vector3.down * sr.GetComponent<RectTransform>().rect.height;
        }

        for (int i = 0; i < sheet[idx].skillSet.Count(); i++)
        {
            var skill = sheet[idx].skillSet[i];
            Debug.Log(skill.Name);
        }
        */

        //if reference single item 
        //var sk0 = sheet[idx].skillSet[0];

    }


}

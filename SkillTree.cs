using System.IO;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class SkillTree : MonoBehaviour
{
    public TextAsset jsonFile;
    public GameObject skillTile;
    private GameObject currentSkill;


    [System.Serializable]
    public class Skill 
    {
        public string id;
        public string displayName;
        public string description;
        public string type;
        public int maxLevel;
        public int cost;
        public string[] preRequisites;

    }
    [System.Serializable]
    public class SkillList
    {
        public Skill[] items;
    }
    public SkillList skills = new SkillList();
    // Start is called before the first frame update
    void Start()
    {
        readJsonFile();
        currentSkill = Instantiate(skillTile);
        //currentSkill.GetComponent<SkillTile>().Initialize(skills.items[0]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void readJsonFile()
    {
        skills = JsonUtility.FromJson<SkillList>(jsonFile.text);
        Debug.Log(skills.items[0].id);
    }
}

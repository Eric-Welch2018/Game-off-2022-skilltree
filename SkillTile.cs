using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTile : MonoBehaviour
{
    private Sprite tileImage;

    public void Initialize(Skill skill)
    {
        this.GetComponent<Image>().sprite = Resources.Load<Sprite>(skill.id);
    }
    // Start is called before the first frame update
    void Start()
    {
        //tileImage = Resources.Load<Sprite>("Rock2");
        //this.GetComponent<Image>().sprite = tileImage;
    }

}

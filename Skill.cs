using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Skill : MonoBehaviour
{
    public string id;
    public string displayName;
    public string description;
    public string type;
    public int maxLevel;
    public int cost;
    public string[] preRequisites;
}

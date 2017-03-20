using UnityEngine;
using System.Collections;

public class HouseCardCatelynStarkScript : MonoBehaviour {

    public int CombatStrenght;
    public string Text;
    public string Name;
    public string House;
	// Use this for initialization
	void Start () {
        CombatStrenght = 0;
        Name = "Catelyn Stark";
        House = "Stark";
        Text = "If you have a Defence Order token in the embattled area, its value is doubled.";
	}

    int CalculateBonusCombatStrenght()
    {
        return CombatStrenght; //todo update catelynscombatstrenght
        /*
         Get embattled area token
         if(token.type == defence)
            return token.value;
         */ 
         
    }

    bool PreFightAction()
    {
        return false;
    }

    bool PostFightAction()
    {
        return false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

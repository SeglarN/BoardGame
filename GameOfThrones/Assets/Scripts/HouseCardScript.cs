using UnityEngine;
using System.Collections;

public class HouseCardScript : MonoBehaviour {

    public bool IsSelected;
    public bool IsAvailable; //not in discardpile

	// Use this for initialization
	void Start () {
        IsSelected = false;
        IsAvailable = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

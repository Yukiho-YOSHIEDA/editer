using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shokika : MonoBehaviour {
    [SerializeField] alldata alld;
    [SerializeField] Button b1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void clik()
    {
        alld.ablestage = 0;
        b1.interactable = false;
    }
}

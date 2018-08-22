using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullettypebutton : MonoBehaviour {
    [SerializeField] Image[] another = new Image[1];
    [SerializeField] int bullettypenum;
    [SerializeField] mapmakwmaneger mpmk;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   public void onclick()
    {
        mpmk.bullettypnum = bullettypenum;
        GetComponent<Image>().color = Color.red;
        another[0].color = Color.white;
    }
}

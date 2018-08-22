using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playstga1 : MonoBehaviour {
   [SerializeField] alldata alld;
    [SerializeField] GameObject selectUIpanel;
	// Use this for initialization
	void Start () {
        if (alld.ablestage == 0)
        {
            GetComponent<Button>().interactable = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void selectstagepanelopen()
    {
        selectUIpanel.SetActive(true);
    }
}

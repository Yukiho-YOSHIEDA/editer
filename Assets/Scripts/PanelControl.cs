using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PanelControl : MonoBehaviour {

	//Rigidbody regidbody;

	// Use this for initialization
	void Start () {
		//regidbody = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClicked(){
		gameObject.GetComponent<Renderer>().material.color = Color.white;
	}
}

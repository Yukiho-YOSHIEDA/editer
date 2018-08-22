using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracont : MonoBehaviour {
  GameObject camera1;
    public float plass;
    // Use this for initialization
    void Start () {
        camera1 = Camera.main.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void cameramove()
    {
        camera1.transform.position += Vector3.up*plass;
    }
}

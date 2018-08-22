using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour {
    float time1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time1 += Time.deltaTime;
        if (time1 > 6)
        {
            SceneManager.LoadScene("selectmodeandstage");
        }
	}
}

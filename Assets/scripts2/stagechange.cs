using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class stagechange : MonoBehaviour {
    [SerializeField] string stagename;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void nextstage()
    {
        SceneManager.LoadScene(stagename);
    }
}

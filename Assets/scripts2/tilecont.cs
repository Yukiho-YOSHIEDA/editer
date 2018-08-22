using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilecont : MonoBehaviour {
    public int i, j;
    public bool initem = false;
    alldata all;

    // Use this for initialization
    void Start() {
        all=(alldata) Resources.Load("assetdata/New Alldata");
    }

    // Update is called once per frame
    void Update() {

    }
    public bool hitaction (int itemnumber){
        if (!initem)
        {
            initem = true;
            GetComponentInParent<mapmakwmaneger>().putitem(i, j, itemnumber);
            GameObject instantObj = (GameObject)GameObject.Instantiate(all.itemprehab[itemnumber].gazou, transform.position-Vector3.forward*5, Quaternion.AngleAxis(0, Vector3.left));
           
            return true;

        }
        return false;
        }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopcam : MonoBehaviour {

    // Use this for initialization
    playersc plsc;

    // Use this for initialization
    void Start()
    {
        plsc = GetComponentInParent<playersc>();
    }

        // Update is called once per frame
        void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy2"))
        {
            plsc.bossfalag = true;
        }
    }
}

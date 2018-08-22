using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playersc : MonoBehaviour {
    bool bossfalag;
    [SerializeField]float speed=10;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (!bossfalag)
        {
            gameObject.transform.position += Vector3.up * Time.deltaTime * speed;
        }
        else
        {
            RaycastHit hit;
            Vector3 rayOrigin = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));

            if (Physics.Raycast(rayOrigin, Camera.main.transform.forward, out hit, 100)){ 
                if (hit.collider.CompareTag("Enemy2"))
                {
                    bossfalag = true;
                }
            }
        }

    }
}

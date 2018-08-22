using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerHPdow : MonoBehaviour {

   bool mutekiflag;
    float time1;
    playersc plsc;
    SpriteRenderer thisima;
	// Use this for initialization
	void Start () {
        plsc = GetComponentInParent<playersc>();
        thisima = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (mutekiflag)
        {
            time1 += Time.deltaTime;
            if (time1 < 0.3)
            {
                thisima.enabled = false;
            }else if (time1 < 0.6)
            {
                thisima.enabled = true;
            }else if (time1 < 0.9)
            {
                thisima.enabled = false;
            }
            else if (time1 < 1.2)
            {
                thisima.enabled = true;
                mutekiflag = false;
                time1 = 0;
            }
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!mutekiflag)
        {
            if (collision.CompareTag("Enemy"))
            {
                mutekiflag = true;
                plsc.HPdown();
            }
            else if (collision.CompareTag("Enemy2"))
            {
                mutekiflag = true;
                plsc.HPdown();
                plsc.HPdown();
            }
        }
    }
    public void HPdown()
    {
        plsc.HPdown();
    }
}

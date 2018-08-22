using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalenemy : MonoBehaviour {
    public float HP;//0.1から１の値が自動で入る
    public int bullettype;//0直進　１三方向
    bool shibou;
    [SerializeField]GameObject bulletprehab1, bulletprehab2,bulletprehab3;
    float time1,time2;
    // playersc plsc;
    SpriteRenderer thisima;
    // Use this for initialization
    void Start()
    {
        HP = HP * 50;
        thisima = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        time2 += Time.deltaTime;
        if (time2 >= 5)
        {
            Instantiate(bulletprehab1,transform.position,transform.rotation);
            if (bullettype == 1)
            {
                GameObject bullet2 = Instantiate(bulletprehab2, transform.position, transform.rotation);
                bullet2.GetComponent<bullet_en>().setAngle(225);
                GameObject bullet3 = Instantiate(bulletprehab3, transform.position, transform.rotation);
                bullet3.GetComponent<bullet_en>().setAngle(315);
            }
            time2 = 0;
        }
        if (shibou)
        {
            time1 += Time.deltaTime;
            if (time1 < 0.3)
            {
                thisima.enabled = false;
            }
            else if (time1 < 0.6)
            {
                thisima.enabled = true;
            }
            else if (time1 < 0.9)
            {
                thisima.enabled = false;
            }
            else if (time1 < 1.2)
            {
                thisima.enabled = true;


            }
            else
            {
               
            }
        }
    }
    public void HPdown()
    {
        Debug.Log("のーまるHPヘリ" + HP);
        HP -= 10;
        if (HP <= 0)
        {
            shibou = true;
           Destroy(gameObject);
        }
    }
}

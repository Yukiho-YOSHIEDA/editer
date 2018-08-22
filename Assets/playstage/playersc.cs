using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playersc : MonoBehaviour {
 public   bool bossfalag=false;
    [SerializeField]float speed=10;
    [SerializeField] GameObject playerpos;
    [SerializeField] GameObject bullet;
    [SerializeField] Slider HPsi;
    int HP = 100;
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
            
            if (Physics.Raycast(rayOrigin, Camera.main.transform.forward, out hit, 1000)){ 
                if (hit.collider.CompareTag("Enemy2"))
                {
                    bossfalag = true;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet,playerpos.transform.position,transform.rotation);
        }
        if (Input.GetKey(KeyCode.RightArrow)&&playerpos.transform.localPosition.x<=20)
        {
            playerpos.transform.position += Vector3.right * Time.deltaTime*10;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && playerpos.transform.localPosition.x >= -45)
        {
            playerpos.transform.position += Vector3.left * Time.deltaTime * 10;
        }

    }
    public void HPdown()
    {

        HP -= 10;
        HPsi.value = (float)HP / 100;
        Debug.Log(HP);
        if (HP <= 0)
        {
            SceneManager.LoadScene("make");
        }
    }
}

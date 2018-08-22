using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletsc : MonoBehaviour {
    [SerializeField] float speed = 50;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.up * Time.deltaTime * speed;
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        
    
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            other.gameObject.GetComponent<normalenemy>().HPdown();
        } else if(other.CompareTag("Enemy2"))
        {
            Debug.Log("ボスに当たったよ");
            Destroy(gameObject);
            other.gameObject.GetComponent<boss>().HPdown();
        }
    }
}

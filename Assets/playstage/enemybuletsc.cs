using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybuletsc : MonoBehaviour {

    [SerializeField] float speed = 20;
    [SerializeField] float speed2 = 0;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * Time.deltaTime * speed;
        transform.position += Vector3.left * Time.deltaTime * speed2;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.CompareTag("Player"))
        {
           // other.gameObject.GetComponent<normalenemy>().HPdown();
            Destroy(gameObject);
        }
      
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_en : MonoBehaviour {

	[SerializeField] float speed = 50;
	[SerializeField] float angle = 270;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(speed * Mathf.Cos(angle * (Mathf.PI / 180)) * Time.deltaTime,
		                                  speed * Mathf.Sin(angle * (Mathf.PI / 180)) * Time.deltaTime,
										  0);
	}

	private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
			other.gameObject.GetComponent<playerHPdow>().HPdown();
            Destroy(gameObject);
        }
	}

	public void setAngle(float angle){
		this.angle = angle;
	}
}

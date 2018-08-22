using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTest : MonoBehaviour {

	private string TileTag = "Tile";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
           
			Ray ray = new Ray();
			RaycastHit hit = new RaycastHit();
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity)){ 
				if(hit.collider.gameObject.CompareTag(TileTag)){
                    Debug.Log(hit.collider.gameObject);
					hit.collider.gameObject.GetComponent<PanelControl>().OnClicked();
				}
			}

		}
	}
}

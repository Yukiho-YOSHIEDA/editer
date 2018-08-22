using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutTile : MonoBehaviour {
    public Vector3[,] tilepos =new Vector3[7,21];
	// Use this for initialization
	void Start () {
		// プレハブ読み込み
		GameObject prefab = (GameObject) Resources.Load("Prefabs/Tile");

		// 配置元のオブジェクト設定
		GameObject stage = GameObject.FindWithTag("Stage");

		//タイル配置
		for(int i = 0; i < 7; i++){
			for(int j = 0; j < 21; j++){

				Debug.Log("x:" + prefab.transform.localScale.x);

				Vector3 tilePos = new Vector3(
					(float)(-30 + prefab.transform.localScale.x * i * 10),
					(float)(100 - prefab.transform.localScale.z * j * 10),
					-1					
				);

				if(prefab != null){
					GameObject instantObj = (GameObject) GameObject.Instantiate(prefab, tilePos, Quaternion.AngleAxis(90, Vector3.left));
					tilepos[i,j] = tilePos;
                    instantObj.transform.parent = stage.transform;
                    
                    tilecont ticon = instantObj.GetComponent<tilecont>();
                    ticon.i = i;ticon.j = j;

				}

			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

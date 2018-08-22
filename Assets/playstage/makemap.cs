using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makemap : MonoBehaviour {
    [SerializeField]alldata alld;
    [SerializeField] GameObject stage;
    mapdataasset nowmapdata;
    [SerializeField] PutTile putTile;
	// Use this for initialization
	void Start () {
        nowmapdata = alld.stage[alld.nowstage].mapdata;
        GameObject prefab = (GameObject)Resources.Load("Prefabs/Tile");

        int leng = nowmapdata.mapitem.Count;
        for(int k=0; k < leng; k++)
        {
            if (nowmapdata.mapitem[k].itemnumber == 1)//normall
            {
               // GameObject instantObj = (GameObject)GameObject.Instantiate(alld.itemprehab[1].item, putTile.tilepos[nowmapdata.mapitem[k].i, nowmapdata.mapitem[k].j], Quaternion.AngleAxis(0, Vector3.left));
                GameObject instantObj = (GameObject)GameObject.Instantiate(alld.itemprehab[1].item, new Vector3(
                    (float)(-30 + prefab.transform.localScale.x * nowmapdata.mapitem[k].i * 10),
                    (float)(100 - prefab.transform.localScale.z *  nowmapdata.mapitem[k].j * 10),-2), Quaternion.AngleAxis(0, Vector3.left));
                instantObj.transform.parent = stage.transform;
                normalenemy norne = instantObj.GetComponent<normalenemy>();
                norne.HP = nowmapdata.mapitem[k].HP;
                norne.bullettype = nowmapdata.mapitem[k].buletnumber;
                //instantObj.transform.position -= Vector3.forward*5;
            }
            else//boss
            {
                GameObject instantObj = (GameObject)GameObject.Instantiate(alld.itemprehab[0].item, new Vector3(
                    (float)(-30 + prefab.transform.localScale.x * nowmapdata.mapitem[k].i * 10),
                    (float)(100 - prefab.transform.localScale.z * nowmapdata.mapitem[k].j * 10), -2), Quaternion.AngleAxis(0, Vector3.left));
                instantObj.transform.parent = stage.transform;
                boss norne = instantObj.GetComponent<boss>();
                norne.HP = nowmapdata.mapitem[k].HP;
                norne.bullettype = nowmapdata.mapitem[k].buletnumber;
               // instantObj.transform.position -= Vector3.forward * 5;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

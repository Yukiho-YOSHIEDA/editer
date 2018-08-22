using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using UnityEngine.UI;

public class mapmakwmaneger : MonoBehaviour {
    alldata all;
    mapdataasset mapdata;
    mapdataasset.mapitemeposition data = new mapdataasset.mapitemeposition();
    [SerializeField] GameObject paramaterpanel;
    [SerializeField] Slider HPslider;
    public int bullettypnum;
    // Use this for initialization
    void Start()
    {
        all = (alldata)Resources.Load("assetdata/New Alldata");
        all.ablestage++;
        mapdata = all.stage[all.ablestage].mapdata;
        mapdata.thisstagenomber = all.ablestage;
        mapdata.mapitem.Clear();
        mapdata.hantei.Clear();
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void putitem(int i, int j, int itemunumber)
    {
       
        data.j = j;
        data.i = i;
        data.itemnumber = itemunumber;
       // mapdata.mapitem.Add(data);
        parameterseting();
    }
    void parameterseting()
    {
        paramaterpanel.SetActive(true);
    }
    public void paramaterwrite()
    {
        data.buletnumber = bullettypnum;
        data.HP = HPslider.value;
        mapdata.mapitem.Add(data);
        paramaterpanel.SetActive(false);
    }
}

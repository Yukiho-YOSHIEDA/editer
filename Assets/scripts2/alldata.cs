using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class alldata : ScriptableObject
{
    public int nowstage; //
    public int ablestage;

    //  [SerializeField] public Entity_Sheet2 write5;
    public List<prehablist> itemprehab=new List<prehablist>();
    public List<stagedatalink> stage = new List<stagedatalink>();
    [System.SerializableAttribute]
    public class prehablist
    {

        [SerializeField] public GameObject gazou;
        [SerializeField] public GameObject item;


    }
    [System.SerializableAttribute]
    public class stagedatalink
    {
        [SerializeField] public mapdataasset mapdata;
        [SerializeField] public string mapimagepath;

           
    }
}

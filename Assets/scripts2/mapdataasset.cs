using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class mapdataasset :ScriptableObject{
    public int thisstagenomber;
    public List<mapitemeposition> mapitem = new List<mapitemeposition>();
    public List<atarihannteiposition> hantei = new List<atarihannteiposition>();
    [System.SerializableAttribute]
    public class mapitemeposition
    {
        [SerializeField] public int i;
        [SerializeField] public int j;
        [SerializeField] public int itemnumber;//種類
        [SerializeField] public int buletnumber;//種類
        [SerializeField] public float HP;

    }
    [System.SerializableAttribute]
    public class atarihannteiposition
    {
        [SerializeField] public int i;
        [SerializeField] public int j;
        [SerializeField] public int parentobjectnomber;
    }

}

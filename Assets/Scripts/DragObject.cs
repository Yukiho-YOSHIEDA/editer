using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Imageコンポーネントを必要とする
[RequireComponent ( typeof ( Image ) )]

// ドラッグとドロップに関するインターフェースを実装する
public class DragObject : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IDropHandler
{ bool wkbo;
    public bool exsitboss;
    [SerializeField] int itemnumber;
    // ドラッグ前の位置
    private Vector2 prevPos;

    public void OnBeginDrag ( PointerEventData eventData )
    {
        // ドラッグ前の位置を記憶しておく
        prevPos = transform.position;
        Debug.Log(prevPos);
    }

    public void OnDrag ( PointerEventData eventData )
    {
        // ドラッグ中は位置を更新する
        transform.position = eventData.position;
    }

    public void OnEndDrag ( PointerEventData eventData )
    {
        // ドラッグ前の位置に戻す
        transform.position = prevPos;
    }

    public void OnDrop ( PointerEventData eventData )
    {
        /*   var raycastResults = new List<RaycastResult>();
           EventSystem.current.RaycastAll ( eventData, raycastResults );

           foreach ( var hit in raycastResults )
           {
               // もし DroppableField の上なら、その位置に固定する
               if ( hit.gameObject.CompareTag ( "DroppableField" ) )
               {
                   transform.position = hit.gameObject.transform.position;
                   this.enabled = false;
               }
           }*/
       
        int layerMask = 1<<8 | 1<<9;
      
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit,100,layerMask)) {
           
            Debug.Log(hit.collider.tag);
            if(!exsitboss) {
                tilecont ticon = hit.collider.gameObject.GetComponent<tilecont>();

                wkbo = ticon.hitaction(itemnumber);
            }
            if (itemnumber == 0)
            {
                exsitboss = wkbo;
            }
        }
           

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gotoplayscen : MonoBehaviour {
    [SerializeField] int num;
    [SerializeField] alldata alld;
	// Use this for initialization
	void Start () {
        if (alld.ablestage < num)
        {
            gameObject.SetActive(false);
            GetComponent<Button>().interactable = false;
        }
        else
        {
            GetComponentInChildren<Text>().text = num.ToString();
            GetComponent<Image>().sprite = Resources.Load<Sprite>(alld.stage[num].mapimagepath) as Sprite;

        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void gotostage()
    {
        alld.nowstage = num;
        SceneManager.LoadScene("playscene");
    }
}

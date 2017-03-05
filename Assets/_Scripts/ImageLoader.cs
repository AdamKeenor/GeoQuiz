using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ImageLoader : MonoBehaviour
{
    public Sprite[] countries;
    public SpriteRenderer s;

    int iC;
    int i;
    // Use this for initialization
    void Start ()
    {
        //how are we loading?
        //what are we loading?
        //where are we loading from?
        countries = Resources.LoadAll<Sprite>("");

        s = GetComponent<SpriteRenderer>();
        iC = countries.Length;
        i = 0;

        //what are we giving the image to? 


    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.anyKeyDown)
        {
            if (i < iC)
            {
                Debug.Log("i: " + i);
                Debug.Log("iC: " + iC);
                Debug.Log("Country: " + countries[i].name);
                s.sprite = countries[i];
                i++;
            }
        }

    }
}

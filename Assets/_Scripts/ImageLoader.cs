using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ImageLoader : MonoBehaviour
{
  
    // Use this for initialization
    void Start ()
    {

    }

    //Create static country sprites
    public static Sprite[] GetCountrySprites()
    {
        //what are we loading and where are we loading from?
        Sprite[] countries = Resources.LoadAll<Sprite>("");

        return countries;
    }

	// Update is called once per frame
	void Update ()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    //Create Object
    SpriteRenderer s;
    Sprite[] countryImages;

    int totalImages;
    int currentImage;

    // Use this for initialization
    void Start ()
    {
        //how are we loading?
        //what are we loading?
        s = GetComponent<SpriteRenderer>();
        countryImages = ImageLoader.GetCountrySprites();

        //i is current image
        totalImages = countryImages.Length;
        currentImage = 0;
    }
	
	// Update is called once per frame
	void Update ()
    { 
        // Checks input
        if (Input.GetKeyUp("right"))
        {
            // Checks Havn't run out of images
            if (currentImage < totalImages)
            {
                Debug.Log("i: " + currentImage);
                Debug.Log("iC: " + totalImages);
                Debug.Log("Country: " + countryImages[currentImage].name);
                s.sprite = countryImages[currentImage];
                currentImage++;
            }
        }

        if (Input.GetKeyUp("left"))
        {
            if (currentImage > 0)
            {
                Debug.Log("i: " + currentImage);
                Debug.Log("iC: " + totalImages);
                Debug.Log("Country: " + countryImages[currentImage].name);
                s.sprite = countryImages[currentImage];
                currentImage--;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class WebCamPhoto : MonoBehaviour
{
    WebCamTexture webCamTexture;

    void Start()
    {
        webCamTexture = new WebCamTexture();
        GetComponent<Renderer>().material.mainTexture = webCamTexture; //Add Mesh Renderer to the GameObject to which this script is attached to
        webCamTexture.Play();
    }

    private void Update()
    {
        GetComponent<RawImage>().texture = webCamTexture;

        if(Input.GetKeyDown("p"))
        {
            StartCoroutine(TakePhoto());
        }
    }

    IEnumerator TakePhoto()  // Start this Coroutine on some button click
    {
        string your_path = "C:/Users/Alienware PC/Desktop";

        Texture2D photo = new Texture2D(webCamTexture.width, webCamTexture.height);
        photo.SetPixels(webCamTexture.GetPixels());
        photo.Apply();

        //Encode to a PNG
        byte[] bytes = photo.EncodeToPNG();
        //Write out the PNG.
        File.WriteAllBytes(your_path + "/photo.png", bytes);

        yield return new WaitForEndOfFrame();
    }
}
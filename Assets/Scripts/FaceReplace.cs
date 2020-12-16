using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FaceReplace : MonoBehaviour
{
    GameObject player;
    Texture2D texture;
    // Start is called before the first frame update
    void Start()
    {
        texture = LoadPicture();
        player = GameObject.Find("My Robot Kyle");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("u"))   //p takes photo, u updates the texture
        {
            player.GetComponent<Renderer>().material.mainTexture = texture;
        }
    }

    public static Texture2D LoadPicture()
    {
        string your_path = "C:/Users/Alienware PC/Desktop/photo.png";
        Texture2D texture = null;
        byte[] byteData;

        if (File.Exists(your_path))
        {
            byteData = File.ReadAllBytes(your_path);
            texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteData);
        }
        else
        {
            Debug.LogError("<Color=Red><a>Missing</a></Color> photo file for texture loading.");
        }
        return texture;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("On Awake");
    }  

    private void onEnable()
    {
        Debug.Log("On onEnable");
    }

    private void onDisable()
    {
        Debug.Log("On onDisable");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("On Start");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("On Update" + (int)(1f/Time.deltaTime));
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(0,0,300,300), "Click Me!"))
        {
            print("Bravo");
        }
    }



    private void FixedUpdate()
    {
       // Debug.Log("On FixedUpdate" + (int)(1f/Time.deltaTime));
    }

    private void LateUpdate()
    {
    // Camera.main.transform.position+=Vector3.right * Time.deltaTime * 5; 
    //her saniye kamerayı 5birim x ekseninde kaydırır. Kamera ayarları bu alanda yapılır.
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour
{

    #region TestFonksiyonlar
    //private void Awake()
    //    {
    //        Debug.Log("On Awake");
    //    }  



    //    // Start is called before the first frame update
    //    void Start()
    //    {
    //        Debug.Log("On Start");
    //    }

    //    private void OnEnable()
    //    {
    //        Debug.Log("On onEnable");
    //    }

    //    private void OnDisable()
    //    {
    //        Debug.Log("On onDisable");
    //    }




    //    // Update is called once per frame
    //    void Update()
    //    {
    //        // Debug.Log("On Update" + (int)(1f/Time.deltaTime));
    //    }

    //    private void OnGUI()
    //    {
    //        if (GUI.Button(new Rect(0,0,300,300), "Click Me!"))
    //        {
    //            print("Bravo");
    //        }
    //    }




    //    private void FixedUpdate()
    //    {
    //       // Debug.Log("On FixedUpdate" + (int)(1f/Time.deltaTime));
    //    }

    //    private void LateUpdate()
    //    {
    //    // Camera.main.transform.position+=Vector3.right * Time.deltaTime * 5; 
    //    //her saniye kamerayı 5birim x ekseninde kaydırır. Kamera ayarları bu alanda yapılır.
    //    }
    #endregion

    #region Colliders ve Triggers

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Degme Basladi");
        Debug.Log(collision.gameObject.name);
        //collision.transform.position += Vector3.right;

    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Degme Devam");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Degme Bitti");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Degme Basladi Trigger");  //triger'lar varlıkların içinden geçebiliyor
        other.transform.position += Vector3.up * 1;
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("İçeride Trigger");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Cikis");
    }

    #endregion

 
}

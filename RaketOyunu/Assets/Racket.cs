using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Racket : MonoBehaviour
{
    public string axisName = "Vertical1";
    public float moveSpeed = 10;
    public Text scoreText;

    public int Score { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveAxis = Input.GetAxis(axisName) * moveSpeed;

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveAxis);
    }

    public void SkorYap()
    {
        Score++;
        scoreText.text = Score.ToString();
    }
}

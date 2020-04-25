using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Racket solRaket, sagRaket;

    Rigidbody2D rb2;
    public float moveSpeed=10;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.velocity = new Vector2(1, 0) * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TagManager tagManager = collision.gameObject.GetComponent<TagManager>();

        GetComponent<AudioSource>().Play();

        if (tagManager == null) return;
        Tag tag = tagManager.myTag;

        if(tag.Equals(Tag.SAG_DUVAR))
        {
            solRaket.SkorYap();
        }

        else if (tag.Equals(Tag.SOL_DUVAR))
        {
            sagRaket.SkorYap();
        }


        if (tag.Equals(Tag.SAG_RAKET))
        {
            DonusYonuHesaplama(collision, -1);
        }
        else if (tag.Equals(Tag.SOL_RAKET))
        {
            DonusYonuHesaplama(collision, 1);
        }


    }

    private void DonusYonuHesaplama(Collision2D collision, int x)
    {
        float a = transform.position.y - collision.gameObject.transform.position.y;
        float b = collision.collider.bounds.size.y;
        float y = a / b;
        rb2.velocity = new Vector2(x, y) * moveSpeed;
    }
}

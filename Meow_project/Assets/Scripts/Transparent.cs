using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparent : MonoBehaviour
{
    public SpriteRenderer sr;

    public float Alpha=1f;
    public float AlphaT;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player"&&Alpha>0.25f) 
        {
            Alpha = Alpha * AlphaT;
            sr.color = new Color(1, 1, 1, Alpha); 
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Alpha > 0.25f)
        {
            Alpha = Alpha * AlphaT;
            sr.color = new Color(1, 1, 1, Alpha);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            sr.color = new Color(1, 1, 1, 1);
            Alpha = 1;
        }
    }
}

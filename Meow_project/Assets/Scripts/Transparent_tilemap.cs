using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Transparent_tilemap : MonoBehaviour
{
    public Tilemap TM;

    public float Alpha=1f;
    public float AlphaT=0.92f;

    private void Start()
    {
        TM = gameObject.GetComponent<Tilemap>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player"&&Alpha>0.25f) 
        {
            Alpha = Alpha * AlphaT;
            TM.color = new Color(1, 1, 1, Alpha); 
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Alpha > 0.25f)
        {
            Alpha = Alpha * AlphaT;
            TM.color = new Color(1, 1, 1, Alpha);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            TM.color = new Color(1, 1, 1, 1);
            Alpha = 1;
        }
    }
}

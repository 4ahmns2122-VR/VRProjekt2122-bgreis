using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupGame : MonoBehaviour
{
    public bool zurueckgestellt;
    public bool zweitesGame;
    public GameObject Tisch1;
    public GameObject Tisch2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Mug"))
        {
            zurueckgestellt = true;
        }

        if (zurueckgestellt == true)
        {
            GameObject a = Tisch2;
            a.GetComponent<AudioSource>().enabled = true;
        }

        if (zurueckgestellt == true)
        {
            GameObject a = Tisch1;
            a.GetComponent<AudioSource>().enabled = false;
        }

        if (zurueckgestellt == true)
        {
            zweitesGame = true;
        }

    }
}

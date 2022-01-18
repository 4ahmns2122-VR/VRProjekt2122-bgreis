using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanGameController : MonoBehaviour
{
    public int punkte = 0;
    public int maxPunkte = 10;
    public bool erstesGame;
    public GameObject gutgemacht;
    public GameObject dosenwerfen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (punkte == 10)
        {
            erstesGame = true;
        }

        if (punkte == 10)
        {
            GameObject a = gutgemacht;
            a.GetComponent<AudioSource>().enabled = true;
        }

        if (punkte == 10)
        {
            GameObject a = dosenwerfen;
            a.GetComponent<AudioSource>().enabled = false;
        }
    }
}

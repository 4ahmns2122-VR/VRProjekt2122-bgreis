using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupGame : MonoBehaviour
{
    public bool zurueckgestellt;

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


    }
}
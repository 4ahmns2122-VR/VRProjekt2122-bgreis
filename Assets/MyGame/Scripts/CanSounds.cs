using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanSounds : MonoBehaviour
{
    public GameObject Can1;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Ball"))
        {
            GameObject a = Can1;
            a.GetComponent<AudioSource>().enabled = true;
        }

    }
}
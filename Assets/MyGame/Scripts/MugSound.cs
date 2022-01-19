using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugSound : MonoBehaviour
{
    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(source.clip);           
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanSounds : MonoBehaviour
{
    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Ball"))
        {
            source.PlayOneShot(source.clip);
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugSound : MonoBehaviour
{
    public GameObject Mug;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(true)
        {
            GameObject a = Mug;
            a.GetComponent<AudioSource>().enabled = true;
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

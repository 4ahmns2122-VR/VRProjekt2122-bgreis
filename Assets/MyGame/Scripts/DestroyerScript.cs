using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    private CanGameController gc;
    private GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {

        gc = FindObjectOfType<CanGameController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Can"))
        {
            gc.Punkte++;
            Destroy(other.gameObject);
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    private CanGameController gc;
    private GameObject Ball;
    //public GameObject PrefabBall;

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

        //if (other.gameObject.tag.Equals("Ball"))
        //{
            //Destroy(other.gameObject);
            //Instantiate(Ball, new Vector3(-5.949, -0.707, -10.502));
        //}

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

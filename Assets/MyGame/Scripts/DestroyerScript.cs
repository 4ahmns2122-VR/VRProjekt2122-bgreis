using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    private CanGameController gc;
    private GameObject Ball;
    public GameObject PrefabBall;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {

        gc = FindObjectOfType<CanGameController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Can"))
        {
            gc.punkte++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag.Equals("Ball"))
        {
            Destroy(other.gameObject);
            spawnBall();

        }


    }

    private void spawnBall()
    {
        if (gc.punkte == 10) { return; }

        GameObject a = Instantiate(PrefabBall) as GameObject;
        a.transform.position = position;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DestroyerScript : MonoBehaviour
{
    private CanGameController gc;
    private GameObject Ball;
    public GameObject prefabBall;
    public GameObject parent;
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

        GameObject a = Instantiate(prefabBall) as GameObject;
        a.transform.SetParent(parent.transform);
        a.GetComponent<XRGrabInteractable>().enabled = true;
        a.transform.localPosition = position;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

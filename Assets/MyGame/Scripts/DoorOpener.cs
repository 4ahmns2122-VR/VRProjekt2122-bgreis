using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    private CupGame cg;
    private CanGameController cgc;
    public GameObject door;
    public Vector3 position;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(cg.zweitesGame == true && cgc.erstesGame == true)
        {
            GameObject a = door;
            a.transform.position = position;
        }
    }
}

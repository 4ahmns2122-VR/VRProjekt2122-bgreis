using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Animator an;
    public CupGame cg;
    public CanGameController cgc;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cg.zweitesGame && cgc.erstesGame)
        {
            an.SetTrigger("DoorTrigger");
        }
    }
}

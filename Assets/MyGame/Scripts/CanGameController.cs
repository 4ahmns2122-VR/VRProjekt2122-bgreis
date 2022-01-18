using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanGameController : MonoBehaviour
{
    public int punkte = 0;
    public int maxPunkte = 10;
    public bool erstesGame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (punkte == 10)
        {
            erstesGame = true;
        }
    }
}

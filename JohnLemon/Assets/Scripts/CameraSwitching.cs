using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitching : MonoBehaviour
{
    public GameObject current;
    public GameObject[] camPoints;
   
    private void Start()
    {
        current.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "HallwayCorner":
                current.SetActive(false);
                current = camPoints[1];
                current.SetActive(true);
                break;
            case "Start":
                current.SetActive(false);
                current = camPoints[0];
                current.SetActive(true);
                break;
            case "OutsideDoor":
                current.SetActive(false);
                current = camPoints[2];
                current.SetActive(true);
                break;
            case "Room":
                current.SetActive(false);
                current = camPoints[3];
                current.SetActive(true);
                break;
            case "OuterRingEntrance":
                current.SetActive(false);
                current = camPoints[4];
                current.SetActive(true);
                break;
            default:
                break;
        }
    }
}



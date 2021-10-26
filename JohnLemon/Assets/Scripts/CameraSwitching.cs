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
            case "OuterRingLeftCorner":
                current.SetActive(false);
                current = camPoints[5];
                current.SetActive(true);
                break;
            case "InnerRingEntrance":
                current.SetActive(false);
                current = camPoints[6];
                current.SetActive(true);
                break;
            case "IRLCorner":
                current.SetActive(false);
                current = camPoints[7];
                current.SetActive(true);
                break;
            case "IRLStraight":
                current.SetActive(false);
                current = camPoints[8];
                current.SetActive(true);
                break;
            case "IRRCorner":
                current.SetActive(false);
                current = camPoints[9];
                current.SetActive(true);
                break;
            case "IRRStraight":
                current.SetActive(false);
                current = camPoints[10];
                current.SetActive(true);
                break;
            case "IREnd":
                current.SetActive(false);
                current = camPoints[11];
                current.SetActive(true);
                break;
            case "ORRCorner":
                current.SetActive(false);
                current = camPoints[12];
                current.SetActive(true);
                break;
            case "ORRStraight":
                current.SetActive(false);
                current = camPoints[13];
                current.SetActive(true);
                break;
            case "ORREnd":
                current.SetActive(false);
                current = camPoints[14];
                current.SetActive(true);
                break;
            case "ORLStraight":
                current.SetActive(false);
                current = camPoints[15];
                current.SetActive(true);
                break;
            case "LRoom":
                current.SetActive(false);
                current = camPoints[16];
                current.SetActive(true);
                break;
            case "RRoom":
                current.SetActive(false);
                current = camPoints[17];
                current.SetActive(true);
                break;
            case "RRoom2":
                current.SetActive(false);
                current = camPoints[18];
                current.SetActive(true);
                break;
            default:
                break;
        }
    }
}



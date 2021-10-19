using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    public GameObject player;
    public GameEnding ending;


    private void OnTriggerEnter(Collider other)
    {
        ending.CaughtPlayer();
    }
}

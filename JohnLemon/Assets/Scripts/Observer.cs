using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public Transform player;
    bool m_isPlayerInRange;
    public GameEnding gameEnding;
    public GameObject parent;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform == player)
        {
            m_isPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {
            m_isPlayerInRange = false;
        }
    }

    private void Update()
    {
        if (m_isPlayerInRange)
        {
            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new Ray(transform.position, direction);

            RaycastHit raycastHit;

            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.collider.transform == player)
                {
                    parent.GetComponent<Chaser>().followPoint(raycastHit.point);
                }
            }
        }
    }
}

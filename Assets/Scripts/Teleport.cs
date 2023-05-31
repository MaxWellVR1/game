using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] GameObject GorillaPlayer;

    [SerializeField] GameObject RespawnPoint;

    [SerializeField] BoxCollider WallCollider;

    private void OnTriggerEnter(Collider other)
    {
        WallCollider.enabled = false;
        
        if (other.gameObject.CompareTag("Body"))
        {
            GorillaPlayer.transform.position = RespawnPoint.transform.position;
        }
        if (other.gameObject.CompareTag("MainCamera"))
        {
            GorillaPlayer.transform.position = RespawnPoint.transform.position;
        }

        WallCollider.enabled = true;
    }
}


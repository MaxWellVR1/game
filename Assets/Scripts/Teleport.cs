using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] GameObject GorillaPlayer;

    [SerializeField] GameObject RespawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Body"))
        {
            GorillaPlayer.transform.position = RespawnPoint.transform.position;
        }
        if (other.gameObject.CompareTag("MainCamera"))
        {
            GorillaPlayer.transform.position = RespawnPoint.transform.position;
        }
    }
}


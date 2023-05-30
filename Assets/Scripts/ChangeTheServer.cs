using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.VR;
public class ChangeTheServer : MonoBehaviour
{
    [SerializeField] public string AppID;
    [SerializeField] public string VoiceID;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("handtag"))
        {
            PhotonVRManager.ChangeServers(AppID, VoiceID);
        }
    }
}
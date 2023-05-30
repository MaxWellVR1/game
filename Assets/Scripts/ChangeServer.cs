using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.VR;

public class ChangeServer : MonoBehaviour
{
        if (other.gameObject.CompareTag("HandTag"))
        {
            PhotonVRManager.ChangeServers(AppID, VoiceID);
        }
}

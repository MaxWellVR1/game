using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSounds : MonoBehaviour
{
    [SerializeField] private AudioSource Hitsound;

    void OnTriggerEnter()
    {
        Hitsound.Play();

    }
}

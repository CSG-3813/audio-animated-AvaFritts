using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    AudioSource audioSrc;
    AudioClip audioClp;

    // Update is called once per frame
    void OnTriggerEnter()
    {
        audioSrc.PlayOneShot(audioClp);
    }
}

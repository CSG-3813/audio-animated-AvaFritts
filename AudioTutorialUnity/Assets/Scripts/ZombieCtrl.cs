using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCtrl : MonoBehaviour
{
    AudioSource audioSrc;
    AudioClip audioClp;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        audioClp = audioSrc.clip;
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        audioSrc.PlayOneShot(audioClp);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCan : MonoBehaviour
{
    private AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (audioSource)
        {
            if (collision.gameObject.name == "Ball")
            {
                audioSource.Play();
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (audioSource)
        {
            if (collision.gameObject.name == "Ball")
            {
                audioSource.Stop();
            }
        }
    }
}

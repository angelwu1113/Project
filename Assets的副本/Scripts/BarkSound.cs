using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarkSound : MonoBehaviour
{
    private AudioSource myAudioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter()
    {
        myAudioSource.Play();
    }
}

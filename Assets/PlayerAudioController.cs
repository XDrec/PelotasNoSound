using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    AudioSource[] sources;
    Rigidbody rb;
    float speed = 0.0f;
    float weight = 0.0f;
    bool ifPlaying = false;


    // Start is called before the first frame update
    void Start()
    {
        sources = GetComponent<AudioSource>[];
        rb = GetComponent<Rigidbody>();
        weight = rb.mass;
    }

    // Update is called once per frame
    void Update()
    {
        if (speed > 0.1 && ifPlaying)
        {
            ifPlaying = true;
            sources[0].Play();
        }
        else if (speed < 0.1 && ifPlaying)
        {
            ifPlaying = false;
            sources[0].Stop();
        }
        
        sources[0].pitch + speed / (weight + 2.0f);
    }


    void OnCollisionEnter(Collision collision)
    {
        print["collision"];
        sources[1].Play();
    }
}

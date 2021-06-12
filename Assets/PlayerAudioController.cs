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
        sources = GetComponent<AudioSource[]>();
        rb = GetComponent<Rigidbody>();
        weight = rb.mass;
        sources[1].pitch = 1.0f / weight;
    }

    // Update is called once per frame
    void Update()
    {
        // Actualizamos la velocidad de la bola con la magnitud actual del rigid object
        this.speed = rb.velocity.magnitude;
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
        sources[0].pitch = speed / (weight + 2.0f); // Aplicamos fórmula para variar el pitch según la velocidad
    }


    void OnCollisionEnter(Collision collision)
    {
        // Cuando hay una colisión reproducimos el sonido 1 del array
        print("collision");
        sources[1].Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionsound : MonoBehaviour
{

    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        // Cuando se detecta colisión mostramos en el terminal que hay colisión y reproducimos el sonido
        print("collision");
        source.Play();
    }
}

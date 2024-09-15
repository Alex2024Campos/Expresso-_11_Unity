using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeMusica : MonoBehaviour
{
    public AudioSource musica;
    // Start is called before the first frame update
    void Start()
    {
        musica = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

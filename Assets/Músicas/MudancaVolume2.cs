using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudancaVolume2 : MonoBehaviour
{
    public VolumeMusica musicas;
    // Start is called before the first frame update
    void Start()
    {
        musicas = GameObject.FindGameObjectWithTag("Musica").GetComponent<VolumeMusica>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collider)
    {
        musicas.musica.volume = 0.5f;
    }
}
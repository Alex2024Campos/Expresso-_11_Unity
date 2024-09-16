using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeMusicaMudar : MonoBehaviour
{
    public VolumeMusica musicaa;
    // Start is called before the first frame update
    void Start()
    {
        musicaa = GameObject.FindGameObjectWithTag("Musica").GetComponent<VolumeMusica>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        musicaa.musica.volume = 0.3f;
    }
}

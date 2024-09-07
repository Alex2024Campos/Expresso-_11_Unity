using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAleatorio : MonoBehaviour
{
    public GameObject[] Spawn;
    int random;
    public float tempoInicio;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnA", tempoInicio, delay);
    }

    // Update is called once per frame
    void SpawnA()
    {
        random = Random.Range(0, Spawn.Length);
        Instantiate(Spawn[random], transform.position, transform.rotation);
      
    }
}

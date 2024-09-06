using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCena : MonoBehaviour
{
    public GameObject personagem;
    // Start is called before the first frame update
    void Start()
    {
        personagem = GameObject.Find("player").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (personagem.transform.position.x + Time.deltaTime <= transform.position.x - 70f)
        {
            Destroy(GameObject.FindGameObjectWithTag("ruas/rua1"));
        }
    }
}

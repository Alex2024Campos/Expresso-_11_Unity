using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaCena : MonoBehaviour
{
    public GameObject personagem;
    //public GameObject[] ruas;
    float posicao = -35f;
    Vector3 proxiPos;

    // Start is called before the first frame update
    void Start()
    {
        personagem = GameObject.Find("player").gameObject;
        proxiPos = new Vector3(4.33f + posicao , 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica se o personagem passou da posição do primeiro bloco
        if (personagem.transform.position.x - transform.position.x <= 15f)
        {
            //int aleatorio = Random.Range(0, ruas.Length);
            Instantiate(GameObject.FindGameObjectWithTag("ruas/rua1"), proxiPos, Quaternion.identity);
            proxiPos += new Vector3(posicao, 0f, 0f);
            transform.position += new Vector3(-20.83f, 0, 0);
        }
    }
}


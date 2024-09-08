using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


public class CriaCena : MonoBehaviour
    {
        public GameObject personagem;
        //public GameObject[] ruas;
        float posicao = -35f;
        Vector3 proxiPos;
        int aleatorio;

        // Start is called before the first frame update
        void Start()
        {
            personagem = GameObject.Find("player").gameObject;
            proxiPos = new Vector3(0 + posicao, 0f, 0f);
        }

        // Update is called once per frame
        void Update()
        {
            aleatorio = Random.Range(1, 4);
            // Verifica se o personagem passou da posição do primeiro bloco
            if (personagem.transform.position.x - transform.position.x <= 15f)
            {
                //instancia uma nova rua
                Instantiate(GameObject.FindGameObjectWithTag("ruas/rua" + aleatorio), proxiPos, Quaternion.identity);
                proxiPos += new Vector3(posicao, 0f, 0f);
                transform.position += new Vector3(-20.83f, 0, 0);   
            }
            if (GameObject.FindGameObjectWithTag("ruas/rua" + aleatorio).transform.position.x - personagem.transform.position.x >= 50f)
            {
                Destroy(GameObject.FindGameObjectWithTag("ruas/rua" + aleatorio));
            }
        }
    }



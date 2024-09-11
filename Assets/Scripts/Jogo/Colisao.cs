using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour
{
    cronometro cronometroo;
    movPers movimentacao;
    // Start is called before the first frame update
    void Start()
    {
        cronometroo = GameObject.FindGameObjectWithTag("Contador").GetComponent<cronometro>();
        movimentacao = GameObject.FindGameObjectWithTag("Player").GetComponent<movPers>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        cronometroo.tempoRestante -= 5;
        movimentacao.M.z -= 10.0f;
    }
}

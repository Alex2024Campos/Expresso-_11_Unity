using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour
{
    cronometro cronometro;
    movPers movimentacao;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        cronometro.tempoRestante -= 5;
        movimentacao.M.z -= 10.0f;
    }
}

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
        if (collision.gameObject.tag == "Player") {
            cronometroo.tempoRestante -= 5;
            Destroy(this.gameObject);
        }
        
    }
}

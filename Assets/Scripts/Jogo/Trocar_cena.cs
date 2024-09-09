using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trocar_cena : MonoBehaviour
{
    [SerializeField]
    private string NPF;

    private void OnTriggerEnter(Collider colision){
        PassarFase();
    }


    private void PassarFase(){
        SceneManager.LoadScene(this.NPF);
    }

}

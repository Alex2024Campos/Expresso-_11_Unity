using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trocar_cena : MonoBehaviour
{
    private void OnTriggerEnter(Collider colision){
        SceneManager.LoadSceneAsync("Estação");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sobre : MonoBehaviour
{
    public GameObject sobrenos;
    public GameObject jogar;
    public GameObject titulo;
    private void Start()
    {
        sobrenos.SetActive(false);
    }
    public void Click()
    {
        sobrenos.SetActive(true);
        jogar.SetActive(false);
        titulo.SetActive(false);
        this.gameObject.SetActive(false);
    }
}

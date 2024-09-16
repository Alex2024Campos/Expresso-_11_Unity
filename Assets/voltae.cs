using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class voltae : MonoBehaviour
{
    public GameObject menuSobreNos;
    public GameObject jogar;
    public GameObject titulo;
    public GameObject sobre;
    public void Clicar() {
        menuSobreNos.SetActive(false);
        jogar.SetActive(true);
        titulo.SetActive(true);
        sobre.SetActive(true);
    }
}

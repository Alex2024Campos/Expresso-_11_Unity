using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public bool jogoEstaPausado = false;
    public GameObject menuPausa;
    public GameObject cronometro;
    public GameObject musica;
    private void Start()
    {
        menuPausa.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { 
            if (jogoEstaPausado)
            {
                Continuar();
            }
            else
            {
                Pausa();
            }
        }
    }

    void Pausa() { 
        menuPausa.SetActive(true);
        Time.timeScale = 0.0f;
        jogoEstaPausado = true;
        cronometro.SetActive(false);
        musica.SetActive(false);
    }

    public void Continuar()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1.0f;
        jogoEstaPausado = false;
        cronometro.SetActive(true);
        musica.SetActive(true);
    }

    public void voltarMenu()
    {
        SceneManager.LoadSceneAsync("Menu");
    }

    public void VoltarDesktop()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaScript : MonoBehaviour
{
    MenuPausa menupausa;
    public GameObject musica;
    // Start is called before the first frame update
    void Start()
    {
        menupausa = GameObject.FindGameObjectWithTag("MenuPausa").GetComponent<MenuPausa>();
    }

    // Update is called once per frame
    void Update()
    {
        if (menupausa.jogoEstaPausado == true)
        {
            musica.SetActive(false);
        }   
        else
        {
            musica.SetActive(true);
        }
    }
}

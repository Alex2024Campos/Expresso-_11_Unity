using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class cronometro : MonoBehaviour
{
    public TextMeshProUGUI contador;
    public GameObject telaGameOver;
    public GameObject crnmetro;
    public GameObject musica;
    GameOver gameoverscript;
    public float tempoRestante = 295;

    // Start is called before the first frame update
    void Start()
    {
        telaGameOver.SetActive(false);
        gameoverscript = GameObject.FindGameObjectWithTag("TelaGameOver").GetComponent<GameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tempoRestante > 0)
        {
            tempoRestante -= Time.deltaTime;
        }
        else if (tempoRestante <= 0)
        {
            telaGameOver.SetActive(true);
            Time.timeScale = 0.0f;
            crnmetro.SetActive(false);
            musica.SetActive(false);
            gameoverscript.Reinicar();
        }
        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos = Mathf.FloorToInt(tempoRestante % 60);
        contador.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}
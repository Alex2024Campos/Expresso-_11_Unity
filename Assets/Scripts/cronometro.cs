using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class cronometro : MonoBehaviour
{
    public TextMeshProUGUI contador;
    [SerializeField] float tempoRestante;
    /*int segundos = 59;
    int minutos;*/
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*for (minutos = 9; minutos > 0; segundos--)
        {
            if (segundos == 0)
            {
                minutos--;
                segundos = 59;
            }
            else if (segundos != 0)
            {
                int minutos;
                int segundos;
            }*/
        tempoRestante -= Time.deltaTime;
        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos = Mathf.FloorToInt(tempoRestante % 60);
        contador.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}
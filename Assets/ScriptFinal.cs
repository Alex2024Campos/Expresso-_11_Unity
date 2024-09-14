using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFinal : MonoBehaviour
{
    public ScriptCutsceneFinal cutscenefinal;
    public GameObject musica;
    // Start is called before the first frame update
    void Start()
    {
        cutscenefinal = GameObject.FindGameObjectWithTag("MenuFinal").GetComponent<ScriptCutsceneFinal>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0.0f;
        cutscenefinal.cutsceneFinal.SetActive(true);
        musica.SetActive(false);
    }
}

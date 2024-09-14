using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScriptCutsceneFinal : MonoBehaviour
{
    public GameObject cutsceneFinal;
    // Start is called before the first frame update
    void Start()
    {
        cutsceneFinal.SetActive(false);
    }

    public void voltarMenu()
    {
        SceneManager.LoadSceneAsync("Menu");
    }
}

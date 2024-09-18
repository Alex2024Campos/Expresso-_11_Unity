using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogar : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadSceneAsync("Rua");
        Time.timeScale = 1.0f;
    }
}

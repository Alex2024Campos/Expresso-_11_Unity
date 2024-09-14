using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Reinicar()
    {
        SceneManager.LoadSceneAsync("Rua");
        Time.timeScale = 1.0f;
    }
}

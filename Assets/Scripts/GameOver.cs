using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Reinicar()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    int random;
    public Vector3 posicaoInicial;
    public GameObject[] obstaculos;
    public float spawnTime, spawnDelay;
    public float velocidade = 5.0f;      // Velocidade do movimento para frente (eixo X)
    public float velocidadeZigZag = 3.0f; // Velocidade do movimento zig-zag no eixo Z
    public float limiteSuperior = -10.343f;  // Limite superior do zig-zag no eixo Z (mais próximo de 0)
    public float limiteInferior = -13.904f;
    private int direcaoZ = 1; // Direção do movimento no eixo Z (1 para cima, -1 para baixo)
    public string sceneName;

    void Start()
    {
        InvokeRepeating("SpawnRandom", spawnTime, spawnDelay);
        posicaoInicial = new Vector3(-8.46f, 1f, -12.15f);
        transform.position = posicaoInicial;
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;


    }
    void SpawnRandom()
    {
        random = Random.Range(0, obstaculos.Length);
        Instantiate(obstaculos[random], transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        if (sceneName == "Rua")
        {
            if (transform.position.x > -109.52f)
            {

                // Movimento para frente no eixo X
                Vector3 movimentoParaFrente = Vector3.right * velocidade * Time.deltaTime;

                // Atualiza a posição do objeto combinando os dois movimentos
                transform.Translate(movimentoParaFrente);
            }
            // Movimento em zig-zag no eixo Z
            Vector3 movimentoZigZag = Vector3.forward * direcaoZ * velocidadeZigZag * Time.deltaTime;
            transform.Translate(movimentoZigZag);

            // Verifica se o objeto atingiu o limite superior ou inferior no eixo Z
            if (transform.position.z >= limiteSuperior)
            {
                direcaoZ = -1; // Inverte a direção para descer (para valores menores no eixo Z)
            }
            else if (transform.position.z <= limiteInferior)
            {
                direcaoZ = 1;  // Inverte a direção para subir (para valores maiores no eixo Z)
            }
        }

        if (sceneName == "Estação")
        {
            if (transform.position.x > -69.05)
            {

                // Movimento para frente no eixo X
                Vector3 movimentoParaFrente = Vector3.left * velocidade * Time.deltaTime;

                transform.Translate(movimentoParaFrente);

                // Atualiza a posição do objeto combinando os dois movimentos

            }
            // Movimento em zig-zag no eixo Z
            Vector3 movimentoZigZag = Vector3.forward * direcaoZ * velocidadeZigZag * Time.deltaTime;
            transform.Translate(movimentoZigZag);

            // Verifica se o objeto atingiu o limite superior ou inferior no eixo Z
            if (transform.position.z >= limiteSuperior)
            {
                direcaoZ = -1; // Inverte a direção para descer (para valores menores no eixo Z)
            }
            else if (transform.position.z <= limiteInferior)
            {
                direcaoZ = 1;  // Inverte a direção para subir (para valores maiores no eixo Z)
            }



        }

    }
}

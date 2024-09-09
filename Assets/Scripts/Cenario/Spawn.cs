using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    int random;
    Vector3 posicao;
    public Vector3 posicaoInicial;
    public GameObject[] obstaculos;
    public float spawnTime, spawnDelay;
    public float velocidade = 5.0f;      // Velocidade do movimento para frente (eixo X)
    public float velocidadeZigZag = 3.0f; // Velocidade do movimento zig-zag no eixo Z
    public float limiteSuperior = -10.343f;  // Limite superior do zig-zag no eixo Z (mais próximo de 0)
    public float limiteInferior = -13.904f;
    private int direcaoZ = 1; // Direção do movimento no eixo Z (1 para cima, -1 para baixo)


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandom", spawnTime, spawnDelay);
        transform.position = posicaoInicial;
        posicaoInicial = new Vector3(0f,0f,0f);


    }

    // Update is called once per frame
    void Update()
    {
        // Movimento para frente no eixo X
        Vector3 movimentoParaFrente = Vector3.right * velocidade * Time.deltaTime;

        // Movimento em zig-zag no eixo Z
        Vector3 movimentoZigZag = Vector3.forward * direcaoZ * velocidadeZigZag * Time.deltaTime;

        // Atualiza a posição do objeto combinando os dois movimentos
        transform.Translate(movimentoParaFrente + movimentoZigZag);

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
    void SpawnRandom()
    {
        random = Random.Range(0 , obstaculos.Length);
        Instantiate(obstaculos[random], transform.position, transform.rotation);
    }
}

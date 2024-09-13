using NUnit.Framework.Constraints;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class movPers : MonoBehaviour
{
    public Vector3 M;
    private CharacterController controller;
    private Animator animacao;



    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animacao = GetComponent<Animator>();
        M = new Vector3(16.31f, 1.24f, -12.29f);
        transform.position = M;
    }

    // Update is called once per frame
    void Update()
    {
        M.x = 0f;
        M.y = 0.0f;
        M.z = 3f * Time.deltaTime;
        transform.Translate(M);

        if (Input.GetKey(KeyCode.W) && transform.position.z > -13.904f)
        {
            M.x = -3f * Time.deltaTime;
            M.y = 0f;
            M.z = 0f;
            transform.Translate(M);
        }
        if (Input.GetKey(KeyCode.S) && transform.position.z < -10.383f)
        {
            M.x = 3f * Time.deltaTime;
            M.y = 0f;
            M.z = 0f;
            transform.Translate(M);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (transform.position.y < 2f)
            {
                M.x = 0f;
                M.y = 0.05f + Time.deltaTime;
                M.z = 0f;
                transform.Translate(M);
            }
        }
        if (transform.position.y <= 1)
        {
            M.x = transform.position.x + Time.deltaTime;
            M.y = 1f + Time.deltaTime;
            M.z = transform.position.z + Time.deltaTime;
            transform.position = M;
        }

        //Ataque "Voadora"
        if (Input.GetKeyUp(KeyCode.A)) {
            animacao.SetInteger("Mediador", 3);
        }
    }

}
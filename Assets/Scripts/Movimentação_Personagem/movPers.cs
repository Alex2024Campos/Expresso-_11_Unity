using NUnit.Framework.Constraints;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class movPers : MonoBehaviour
{
    public Vector3 M;

    private bool canjump = true;
    private Rigidbody rig;
    private CharacterController controller;
    private Animator animacao;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animacao = GetComponent<Animator>();
        M = new Vector3(16.31f, 1.24f, -12.29f);
        transform.position = M;
        //pegando o Rigidbody do player
        rig = GetComponent<Rigidbody>();
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
        if (Input.GetKeyDown(KeyCode.Space) &&  canjump == true)
        {   
            rig.AddForce(new Vector3(0f, 4f + Time.deltaTime, 0f), ForceMode.Impulse);
        }
        if (transform.position.y >= 1.5f)
        {
            canjump = false;
        }
        // NÃO FUNCIONA POR ALGUM MOTIVO!!!!
        // VAI FUNCIONAR!!!! CONFIA 
        else if (transform.position.y <= 1.15f)
        {
            canjump = true;
        }



        if (transform.position.y <= 0.99)
        {
            M.x = transform.position.x + Time.deltaTime;
            M.y = 1f;
            M.z = transform.position.z + Time.deltaTime;
            transform.position = M;
        }   
    }
}
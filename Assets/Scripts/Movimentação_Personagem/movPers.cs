using NUnit.Framework.Constraints;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class movPers : MonoBehaviour
{
    public Vector3 M;

    // Start is called before the first frame update
    void Start()
    {
        M = new Vector3(16.31f, 1.24f, -12.29f);
        transform.position = M;
    }

    // Update is called once per frame
    void Update()
    {
        M.x = 0.0f;
        M.y = 0.0f;
        M.z = 0.05f; ;
        transform.Translate(M);

        if (Input.GetKey(KeyCode.W) && transform.position.z > -13.904f)
        {
            M.x = -0.05f;
            M.y = 0f;
            M.z = 0f;
            transform.Translate(M);
        }
        if (Input.GetKey(KeyCode.S) && transform.position.z < -10.383f)
        {
            M.x = 0.05f;
            M.y = 0f;
            M.z = 0f;
            transform.Translate(M);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (transform.position.y < 2f)
            {
                M.x = 0f;
                M.y = 0.05f;
                M.z = 0f;
                transform.Translate(M);
            }
        }

    }

}
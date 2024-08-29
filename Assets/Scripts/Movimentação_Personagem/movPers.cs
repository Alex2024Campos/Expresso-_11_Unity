using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPers : MonoBehaviour
{
    Vector3 M; 
    // Start is called before the first frame update
    void Start()
    {
        M = new Vector3(16.31f, 1.511f, -12.29f);
        transform.position = M; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.z > -13.7f)
        {
            M.x = 0f;
            M.y = 0f;
            M.z = -0.01f;
            transform.Translate(M);
        }
        if (Input.GetKey(KeyCode.S) && transform.position.z < -10.83)
        {
            M.x = 0f;
            M.y = 0f;
            M.z = 0.01f;
            transform.Translate(M);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if(transform.position.y < 2.5 && transform.position.y > 1.5)
            {
                M.x = 0f;
                M.y = 0.05f;
                M.z = 0f;
                transform.Translate(M);
            }      
        }
        M = new Vector3(-0.01f, 0f, 0f);
        transform.Translate(M);
    }
}

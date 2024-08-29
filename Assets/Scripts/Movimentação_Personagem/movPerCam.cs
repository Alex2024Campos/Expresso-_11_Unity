using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPerCam : MonoBehaviour
{
    Vector3 M;
    // Start is called before the first frame update
    void Start()
    {
        M = new Vector3(16.31f, 3.441385f, -7.811185f);
        transform.position = M;
    }

    // Update is called once per frame
    void Update()
    {
        M = new Vector3(0.01f, 0f, 0f);
        transform.Translate(M);
    }
}

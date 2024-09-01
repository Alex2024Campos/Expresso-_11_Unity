using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCam : MonoBehaviour
{
    public Vector3 M;
    public float v;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = M;
    }

    // Update is called once per frame
    void Update()
    {
        M = new Vector3(v, 0f, 0f);
        transform.Translate(M);
    }

}

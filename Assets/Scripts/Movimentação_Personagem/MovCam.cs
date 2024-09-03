using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCam : MonoBehaviour
{
    public Vector3 Mcam;
    // Start is called before the first frame update
    void Start()
    {
        Mcam = new Vector3(16.31f, 1.734f, -8.659f);
        transform.position = Mcam;
    }

    // Update is called once per frame
    void Update()
    {
        Mcam.x = 0.05f;
        Mcam.y = 0.0f;
        Mcam.z = 0.0f;
        transform.Translate(Mcam);
    }

}

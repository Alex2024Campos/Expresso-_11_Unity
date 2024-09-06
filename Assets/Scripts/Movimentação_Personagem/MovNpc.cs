using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovNpc : MonoBehaviour
{
    public Vector3 Mnpc;
    // Start is called before the first frame update
    void Start()
    {
        Mnpc = new Vector3();
        transform.position = Mnpc;
    }

    // Update is called once per frame
    void Update()
    {
        Mnpc.x = -0.001f + Time.deltaTime;
        Mnpc.y = 0f;
        Mnpc.z = 0f;
        transform.Translate(Mnpc);
    }
}

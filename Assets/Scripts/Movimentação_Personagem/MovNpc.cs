using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovNpc : MonoBehaviour
{
    GameObject spawn;
    Vector3 Mnpc;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("Spawn").gameObject;
        Mnpc = spawn.transform.position;
        //transform.position = Mnpc;
        transform.Rotate(0f, 90f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
            Mnpc.x = 0f;
            Mnpc.y = 0f;
            Mnpc.z = 5f * Time.deltaTime;
            transform.Translate(Mnpc);
        if (transform.position.x >= 17.45f){
            Destroy(this.gameObject);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien_Move2 : MonoBehaviour
{
    public float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-moveSpeed, 0, 0) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(moveSpeed, 0, 0) * Time.deltaTime);
        }
    }
}

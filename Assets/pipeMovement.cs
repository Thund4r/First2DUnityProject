using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(-2, 0, 0) * Time.deltaTime;
        if (transform.position.x < -13)
        {
            Destroy(gameObject);
        }
        
    }
}

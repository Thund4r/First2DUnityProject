using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JaneScript : MonoBehaviour
{
    public Rigidbody2D myRatObject;
    public float flapStrength;

    // Start is called before the first frame update
    void Start()
    {
        myRatObject.velocity = Vector2.up * 5;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            myRatObject.velocity = new Vector2(0, 1) * flapStrength;
        }
        
    }
}

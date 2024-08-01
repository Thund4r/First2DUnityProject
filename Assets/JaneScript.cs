using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JaneScript : MonoBehaviour
{
    public Rigidbody2D myRatObject;
    public float flapStrength;
    public logic gameOverLogic;
    private bool IsAlive= true;

    // Start is called before the first frame update
    void Start()
    {
        myRatObject.velocity = Vector2.up * 5;
        gameOverLogic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logic>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsAlive) {
            myRatObject.velocity = new Vector2(0, 1) * flapStrength;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOverLogic.gameOver();
        IsAlive = false;

    }
}

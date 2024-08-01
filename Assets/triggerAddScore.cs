using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAddScore : MonoBehaviour
{
    public logic scoreLogic;
    // Start is called before the first frame update
    void Start()
    {
        scoreLogic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            scoreLogic.addScore();
        }
        
    }
}

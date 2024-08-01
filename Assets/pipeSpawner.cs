using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 0.3f;
    private float timer = 0;
    public float heightDiff = 0;

    // Start is called before the first frame update
    void Start()
    {
        timer = spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else {
            float randY = transform.position.y + Random.Range(-heightDiff, heightDiff);
            Instantiate(pipe, new Vector3 (transform.position.x, randY, transform.position.z), transform.rotation);
            timer = 0;
        }
       
    }
}

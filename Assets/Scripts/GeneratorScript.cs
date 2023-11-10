using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiperScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float offset = 5;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float high = transform.position.y + offset;
        float low = transform.position.y - offset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(low, high), 0), transform.rotation);
    }
}

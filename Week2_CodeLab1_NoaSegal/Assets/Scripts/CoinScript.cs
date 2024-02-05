using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //increase score by 1:
        GameManager.instance.score++;
        //can reference .instance because there's only one
        
        //relocate coin to a new location:
        transform.position = new Vector3(Random.Range(-5, 5), Random.Range(-3, 3));
    }
}

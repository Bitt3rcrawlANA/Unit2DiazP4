using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SammichCollide : MonoBehaviour
{

    public float score;

    void Awake()
    {
        Debug.Log("Score:" + score);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        score += 1;
        Debug.Log("Score:" + score);

        Destroy(gameObject);
        Destroy(other.gameObject);


    }
}

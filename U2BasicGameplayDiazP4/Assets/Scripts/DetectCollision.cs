using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DetectCollision : MonoBehaviour
{

    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Sandwich"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
        }

        
    }
}

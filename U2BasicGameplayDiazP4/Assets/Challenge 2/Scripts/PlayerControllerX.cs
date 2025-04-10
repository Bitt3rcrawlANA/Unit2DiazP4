using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool cooldownActive;
    private WaitForSeconds cooldownTime = new WaitForSeconds(2.0f);

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!cooldownActive)
            {
                Dog();
            }
        }
    }

    void Dog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        cooldownActive = true;
        StartCoroutine(DogCooldown());
    }
    private IEnumerator DogCooldown()
    {
        yield return cooldownTime;
        cooldownActive = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_item : MonoBehaviour
{
    public AudioClip pickupSound;
    GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            gameManager.currentPickups += 1;
            Destroy(gameObject);
        }
    }
}

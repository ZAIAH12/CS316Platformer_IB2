using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
     PointCounter pointCounter;

    GameManager sammy;

    // Start is called before the first frame update
    void Start()
    {
        sammy = GameObject.FindGameObjectWithTag("MrManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") 
        {
            sammy.highScore ++;
            Destroy(gameObject);
        }
    }
}

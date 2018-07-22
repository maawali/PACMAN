using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public int CollectableValue = 1;

    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameManager.AddScore(CollectableValue);
            Destroy(gameObject);
        }
    }
}

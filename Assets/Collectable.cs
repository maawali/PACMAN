using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public int CollectableValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        pacman player = new pacman();
        if(other.gameObject.tag == "Player")
        {
            player.Score(CollectableValue);
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacman : MonoBehaviour {
    // ---------- PUBLIC INSPECTOR INTERFACE -----------------
    public float Speed = 200.0f;

    // ---------- PRIVATE SCRIPTING INTERFACE -----------------
    private Vector3 _currentDirection;
    private Vector3 _nextDirection;
    private int totalScore = 0;
    // Update is called once per frame
    void FixedUpdate()
    {
        // Find the desired next direction:
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (vertical > 0)
        {
            // Going Up:
            _nextDirection = Vector3.forward;
        }
        else if (vertical < 0)
        {
            // Going Down:
            _nextDirection = Vector3.back;
        }
        else if (horizontal > 0)
        {
            // Going Right:
            _nextDirection = Vector3.right;
        }
        else if (horizontal < 0)
        {
            // Going Left:
            _nextDirection = Vector3.left;
        }

        // Move the character:
        transform.Translate(_nextDirection * Time.deltaTime * Speed);
    }
}

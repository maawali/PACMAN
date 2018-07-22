using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int score;
    public Text scoreText;

    // Use this for initialization
    void Start () {
        scoreText.text = "Score : " + score;
    }

    public void AddScore(int collects)
    {
        score += collects;
        scoreText.text = "Score : " + score;
    }
}

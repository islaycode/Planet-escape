 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {



    int score; // for storig score
    Text scoreText; // Text is UI element and scoreText is the variable 
                    // Use this for initialization
    void Start() {
        scoreText = GetComponent<Text>(); // To get the access Text UI 
        scoreText.text = score.ToString(); // To convert the score into the string object
    }

    public void scoreHit(int scoreIncrease)
    {
        score = score + scoreIncrease;
        scoreText.text = score.ToString();
    }
}

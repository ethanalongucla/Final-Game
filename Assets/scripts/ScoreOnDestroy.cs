using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreOnDestroy : MonoBehaviour
{
    //Lets get our reference to the text object
    public Text scoreText;

    //Our score variable
    private int score;

    // Use this for initialization
    private void Start()
    {
        //Make sure our score is 0 when the game starts

        score = 0;
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        //Display our current score
        scoreText.text = "Score: " + score;
    }

    //private Function to private add points private to our private current score private and display it

    public void AddToScore(int amountToAdd)

    {
        score = score + amountToAdd;
        scoreText.text = "Score: " + score.ToString();
    }
}
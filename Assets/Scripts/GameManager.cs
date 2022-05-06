using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager inst;
    public Text scoreText;
    public PlayerMovement playerMovement;

    public void IncrementScore(){
        score++;
        scoreText.text = "Score: " + score.ToString();
        playerMovement.speed += playerMovement.acceleration;


    }
    private void Awake(){
        inst = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
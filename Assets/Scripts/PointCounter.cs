using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public Text pointScoreCounter;
    public Text livesCounter;

    
    GameManager sammy;

    // Start is called before the first frame update
    void Start()
    {
        sammy = GameObject.FindGameObjectWithTag("MrManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        pointScoreCounter.text = "Score: " + sammy.highScore;
        livesCounter.text = "Lives: " + sammy.numLivesLeft;
    }
}

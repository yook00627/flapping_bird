using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    // counting score of the game
    public static int score;

    // reset score to 0 when restart
    private void Start()
    {
        score = 0;
    }

    // displaying score dynamically
    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();
    }
}

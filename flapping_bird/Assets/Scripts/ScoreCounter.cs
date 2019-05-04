using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    // set score to increase when collision is detected
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreDisplay.score++;
    }
}

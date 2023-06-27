using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public GameObject player1Canvas;
    public GameObject player2Canvas;

    public void Player1Turn()
    {
        Time.timeScale = 1;

        player2Canvas.SetActive(false);
        player1Canvas.SetActive(true);
    }
    public void Player2Turn()
    {
        Time.timeScale = 1;
        player2Canvas.SetActive(true);
        player1Canvas.SetActive(false);
    }
}


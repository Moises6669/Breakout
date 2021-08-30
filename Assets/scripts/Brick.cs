using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    GameManager gameManager;
    GameObject gameManagerOj;

    private void Start()
    {
        gameManagerOj = GameObject.Find("GameManager");
        gameManager = gameManagerOj.GetComponent<GameManager>();
        gameManager.brickOnLevel++;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManagerOj = GameObject.Find("GameManager");
        gameManager = gameManagerOj.GetComponent<GameManager>();
        gameManager.brickOnLevel--;
        Destroy(gameObject);
    }

}

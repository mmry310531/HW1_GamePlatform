using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinish : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && tag == "Goal")
        {
            // TODO
            Time.timeScale = 0;
            Debug.Log("Well Done");
        }
    }
}

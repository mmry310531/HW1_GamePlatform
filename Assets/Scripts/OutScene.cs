using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutScene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Monster")
        {
            //TODO
            Debug.Log("You're Dead");
            Time.timeScale = 0;
        }
        if (collision.tag == "UnderGround")
        {
            //TODO
            Debug.Log("You're Dead");
            Time.timeScale = 0;
        }

        if( tag == "tile" && collision.tag == "DeleteTile")
        {
            Destroy(this.gameObject);
        }

    }
}

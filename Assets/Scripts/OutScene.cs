using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutScene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Monster" && tag == "Player")
        {
            //TODO
            Debug.Log("You're Dead");
            Time.timeScale = 0;
        }
        if (collision.tag == "UnderGround" && tag == "Player")
        {
            //TODO
            Debug.Log("You're Dead");
            Time.timeScale = 0;
        }

        if( tag == "tile" && collision.tag == "DeleteTile")
        {
            Destroy(this.gameObject);
        }
        if(tag == "Sword" && collision.tag == "Enemy")
        {
            //Debug.Log("hello");
            collision.gameObject.GetComponent<Health>().GetHurt = true;
        }

    }
}

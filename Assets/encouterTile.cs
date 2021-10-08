using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class encouterTile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "tile")
        {
            Debug.Log("hellO");
            Destroy(collision.gameObject);
        }
    }
}

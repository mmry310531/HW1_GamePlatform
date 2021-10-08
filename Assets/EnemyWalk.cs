using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    public float walkDistance;
    public SpriteRenderer renderer;
    public Vector3 Originalposition;
    public bool direction;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        renderer = this.GetComponent<SpriteRenderer>();
        Originalposition = this.transform.position;
        direction = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if((Originalposition - transform.position).magnitude >= walkDistance){
            if (direction)
            {
                direction = false;
            }
            else
            {
                direction = true;
            }
        }

        if (direction)
        {
            renderer.flipX = false;
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
        }
        else
        {
            renderer.flipX = true;
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
        }


    }
}

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
        


        if (direction)
        {
            if ((Originalposition.x - transform.position.x) >= walkDistance)
            {
                if (direction)
                {
                    direction = false;
                }
                else
                {
                    direction = true;
                }
            }
            renderer.flipX = false;
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
        }
        else
        {
            if ((Originalposition.x - transform.position.x) <= -walkDistance)
            {
                if (direction)
                {
                    direction = false;
                }
                else
                {
                    direction = true;
                }
            }
            renderer.flipX = true;
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
        }


    }
}

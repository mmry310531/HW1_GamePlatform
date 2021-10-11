using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = new Vector3(Player.transform.position.x, 0, -10) ;
        this.transform.position = Vector3.Lerp(this.transform.position, offset, 0.1f);
    }
}

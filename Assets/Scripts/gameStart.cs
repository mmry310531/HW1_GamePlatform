using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStart : MonoBehaviour
{

    public float BackGroundSpeed;



    public GameObject BackGround;
    public GameObject Monster;
    public GameObject Player;
    public GameObject Tile;
    public GameObject DeleteTile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tile.transform.position += new Vector3(-BackGroundSpeed * Time.deltaTime, 0, 0);
        BackGround.transform.position += new Vector3(BackGroundSpeed * Time.deltaTime, 0, 0);
        Monster.transform.position += new Vector3(BackGroundSpeed * Time.deltaTime, 0, 0);
        DeleteTile.transform.position += new Vector3(BackGroundSpeed * Time.deltaTime, 0, 0);
        //Player.transform.position += new Vector3(BackGroundSpeed * Time.deltaTime, 0, 0);
    }
}

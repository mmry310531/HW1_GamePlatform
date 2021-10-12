using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameStart : MonoBehaviour
{

    public float BackGroundSpeed;



    public GameObject BackGround;
    public GameObject Monster;
    public GameObject Player;
    public GameObject Tile;
    public GameObject DeleteTile;
    public Canvas canvas;
    public int HeartNum;
    public GameObject[] hearts;
    public Health playerHealth;
    public float getHurtTime;

    // Start is called before the first frame update
    void Start()
    {

        hearts = new GameObject[HeartNum];
        for(int i = 0; i < HeartNum; i++)
        {
            hearts[i] = canvas.transform.GetChild(i).gameObject;
        }
        playerHealth = Player.GetComponent<Health>();
        getHurtTime = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if(getHurtTime > 0f)
        {
            getHurtTime -= Time.deltaTime;
        }
        Tile.transform.position += new Vector3(-BackGroundSpeed * Time.deltaTime, 0, 0);
        BackGround.transform.position += new Vector3(BackGroundSpeed * Time.deltaTime, 0, 0);
        Monster.transform.position += new Vector3(BackGroundSpeed * Time.deltaTime, 0, 0);
        DeleteTile.transform.position += new Vector3(BackGroundSpeed * Time.deltaTime, 0, 0);

        if (HeartNum <= 0)
        {
            //TODO UI player dead
            Debug.Log("You're Dead");
            Time.timeScale = 0;
            
        }

        if (playerHealth.GetHurt && getHurtTime < 0f)
        {
            HeartNum--;
            Destroy(hearts[(HeartNum)]);
            getHurtTime = 2f;
        }


        //Player.transform.position += new Vector3(BackGroundSpeed * Time.deltaTime, 0, 0);
    }
}

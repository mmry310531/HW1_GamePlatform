using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity.Examples;
public class Health : MonoBehaviour
{
    public GameObject Player;
    public BasicPlatformerController BPC;
    public OutScene outScene;
    public int health;
    public Renderer renderer;
    public Color OriginalColor;
    public bool GetHurt;
    public bool GetHurtToggle;
    // Start is called before the first frame update

    public float hurtTime = 1f;
    public float hurtTimeStart = 0.6f;
    void Start()
    {

        BPC = Player.GetComponent<BasicPlatformerController>();
        renderer = this.GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetHurt)
        {
            if (GetHurtToggle)
            {
                renderer.material.SetFloat("_FillPhase", 0.5f);
                GetHurtToggle = false;
            }
            else
            {
                renderer.material.SetFloat("_FillPhase", 0f);
                GetHurtToggle = true;
            }

            if (hurtTime > 0f)
            {
                hurtTime -= 0.3f * Time.deltaTime;
            }
            else
            {
                health--;
                GetHurt = false;
                hurtTime = hurtTimeStart;
                renderer.material.SetFloat("_FillPhase", 0f);
            }
        }
        if (health == 0)
        {
            
            if(tag == "Player")
            {
                
                // end game
            }
        }
        //else
        //{
            
        //}
    }


    void EnemyGotHurt()
    {
        if (BPC.attack)
        {
            Destroy(this.gameObject);
        }
    }
    void PlayerGotHurt()
    {
        Debug.Log("Player Got Hurt");
        if (!GetHurt)
        {
            GetHurt = true;
        }
    }



    private void OnTriggerStay2D(UnityEngine.Collider2D other)
    {
        //Debug.Log(other.tag);
        if(other.tag == "Sword" && tag == "Enemy")
        {
            EnemyGotHurt();
            //collision.gameObject.GetComponent<Health>().GetHurt = true;
        }

        if(other.tag == "Enemy" && tag == "Player")
        {
            PlayerGotHurt();
        }
    }


}

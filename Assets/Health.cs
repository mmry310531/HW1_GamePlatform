using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
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
        renderer = this.GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetHurt)
        {
            if (health == 1)
            {
                // health --;
                // healt = 0;
                if (tag == "Enemy")
                {
                    Destroy(this.gameObject);
                }
            }
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
                //TODO
                // end game
            }
        }
        //else
        //{
            
        //}
    }
}

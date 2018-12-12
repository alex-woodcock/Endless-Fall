using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
    public Animator anim;
    public Rigidbody2D rb2d;
    public float yOffset=0f;
    float dabFrames=0;
    bool canDab = true;
    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        anim.Play("Yosuke-Fallspin");
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Debug.Log(GetComponent<Rigidbody2D>().velocity.y);
        if (GetComponent<Rigidbody2D>().velocity.y <= -10f)
        {
            rb2d.velocity = new Vector2(0, -10);
        }
        if (dabFrames > 0)
        {
            dabFrames--;
            ///TODO INVINCIBILITY DURING THIS MAN ADD IT WHEN YOU ADD DAMAGE
        }
        else if (Input.GetKey(KeyCode.Space) && canDab)//tap screen to use ability
        {
            anim.Play("Player-Dab");
            dabFrames = 30;
            //GameObject.Find("cutIn-Yosuke").GetComponent(typeof(cutInMove)).CutIn(120, -10, 0, -2f);
            gameObject.cutIn-Yosuke<cutInMove>().CutIn(120, -10, 0, -2f);

        }
        else
        {
            anim.Play("Yosuke-Fallspin");
            //////////////////////////////////still in curly bracket
            if (Input.GetKey(KeyCode.W))
            {
                if (yOffset > -3.8)
                {
                    transform.Translate(0, 0.2f, 0);
                    yOffset -= 0.2f;
                }
                else
                {
                    //dont omegalul
                }
            }
            if (Input.GetKey(KeyCode.S))
            {
                if (yOffset < 3.2)
                {
                    transform.Translate(0, -0.2f, 0);
                    yOffset += 0.2f;
                }
                else
                {
                    //dont lul
                }

            }
            if (Input.GetKey(KeyCode.A))
            {
                if (this.transform.position.x > -2.2f)
                {
                    transform.Translate(-0.14f, 0, 0);
                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                if (this.transform.position.x < 2.2f)
                {
                    transform.Translate(0.14f, 0, 0);
                }
            }
            /////////////////////now its ends
        }
    }
}

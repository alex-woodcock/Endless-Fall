using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
    public Animator anim;
    public Rigidbody2D rb2d;
    public float yOffset=0f;
    public float dabFrames=0;
    public bool canDab = true;

    public void SetAnim(string animName)
    {
        anim.Play(animName);
    }

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
            //default .6, .6, 1
            transform.localScale = new Vector3(0.7f, 0.7f, 1);
            ///TODO INVINCIBILITY DURING THIS MAN ADD IT WHEN YOU ADD DAMAGE
        }
        else
        {
            transform.localScale = new Vector3(0.6f, 0.6f, 1);
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

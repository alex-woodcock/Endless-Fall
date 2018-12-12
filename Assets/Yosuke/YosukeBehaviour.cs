using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YosukeBehaviour : MonoBehaviour
{
    public Animator anim;
    bool standing = false;
    int crouching = 0;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.S))
        {
            crouching = 0;
            Debug.Log("test");
        }
        if (Input.GetKey(KeyCode.A))
        {
            standing = true;
            anim.Play("YosukeIdle");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (crouching == 0)
            {
                anim.Play("YosukeCrouchStart");
                
            }
            crouching++;
            if (crouching == 2)
            {
                anim.Play("YosukeCrouch");
            }
        }
        else if (standing)
        {
            anim.Play("YosukeRun");
            standing = false;
        }
    }
}

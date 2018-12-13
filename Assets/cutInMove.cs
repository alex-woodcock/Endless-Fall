using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutInMove : MonoBehaviour {
    public int framesActive = 0;
    public float xPosition = 0f;
    public float yPosition = 2f;
    public float i = -2f;
    SpriteRenderer m_SpriteRenderer;
    public Color color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
    private PlayerBehaviour player;
    /*
    int framesActive = 120;
    int xPosition = -10;
    int yPosition = 0;
    float i = -2f;
    */
    public GameObject cutIn;
    IEnumerator Wait(int framesToWait)
    {
        for(int i=0; i<framesToWait;i++)
        {
            yield return null;
        }
    }
    /*
    public void CutIn(int framesActive, int xPosition, int yPosition, float i)
    {
        //CutIn.SetActive(true);

        while (framesActive > 0)
        {
            //Wait(1);
            StartCoroutine(Wait(1));
            //
            if (i * i / 10f > 0.05f)
            {
                transform.Translate(i * i / 10f, 0, 0);
            }
            //
            if (i<-1f)
            {
                transform.Translate(0.1f, 0, 0);
            }
            else if (i<1f)
            {
                transform.Translate(0.02f, 0, 0);
            }
            else
            {
                transform.Translate(0.1f, 0, 0);
            }

            framesActive--;
            i = i + 0.05f;
        }

    }
    */
    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<PlayerBehaviour>();
    }
    // Use this for initialization
    void Start () {
        //go to the x y coords

        //CutIn(120, -10, 0, -2f);
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        //m_SpriteRenderer.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {
        m_SpriteRenderer.color = color;
        if (Input.GetKey(KeyCode.Space)/* && player.canDab*/)//tap screen to use ability
        {
            player.SetAnim("Player-Dab");
            player.dabFrames = 30;
            //GameObject.Find("cutIn-Yosuke").GetComponent(typeof(cutInMove)).CutIn(120, -10, 0, -2f);
            //gameObject.cutIn-Yosuke<cutInMove>().CutIn(120, -10, 0, -2f);
            ///transform.position = new Vector2(xPosition, yPosition);
            transform.position = GameObject.Find("Player").transform.position;
            //transform.Translate(xPosition, yPosition, -9);
            framesActive = 60;
            color.a = 0.0f;

        }
        ////THIS IS SUPER BUDGET dont look pls
        if (framesActive>0)
        {
            /*
            if (i < -1.5f)
            {
                transform.Translate(0.3f, 0, 0);
            }
            else if (i < 1.5f)
            {
                transform.Translate(0.06f, 0, 0);
            }
            else
            {
                transform.Translate(0.3f, 0, 0);
            }

            framesActive--;
            if (framesActive<80)
            {
                transform.position = new Vector2(0, 20);
            }
            i = i + 0.05f;
            */
            
            if (framesActive>40)
            {
                color.a = color.a + 0.16f;
            }
            else if (framesActive<21)
            {
                color.a = color.a - 0.16f;
            }
            
            framesActive--;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInBehaviour : MonoBehaviour {
    public int framesActive = 0;
    public float xPosition = 0f;
    public float yPosition = 2f;
    public float i = -2f;
    bool waited = true;
    SpriteRenderer m_SpriteRenderer;
    public Color color = new Color(1f, 1f, 1f, 0.5f);
    private PlayerBehaviour player;
    //persona animator starts
    public GameObject PersonaBehaviour;
    Animator personaAnim;
    //and ends

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

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<PlayerBehaviour>();
        personaAnim = GameObject.Find("Persona").GetComponent<Animator>();
    }
    // Use this for initialization
    void Start () {
        //go to the x y coords

        //CutIn(120, -10, 0, -2f);
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        //m_SpriteRenderer.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        m_SpriteRenderer.color = color;
        if (Input.GetKey(KeyCode.Space)/* && player.canDab*/)//tap screen to use ability
        {
            
            personaAnim.Play("jiraiyaSmoke");
            //////////////////////////////////////////////////////////////////////////////////////////////////player.SetAnim("Player-Dab");
            waited = false;
            //
            player.dabFrames = 90;
            //GameObject.Find("cutIn-Yosuke").GetComponent(typeof(cutInMove)).CutIn(120, -10, 0, -2f);
            //gameObject.cutIn-Yosuke<cutInMove>().CutIn(120, -10, 0, -2f);
            ///transform.position = new Vector2(xPosition, yPosition);
            //transform.position = GameObject.Find("Player").transform.position;
            transform.position = new Vector3(GameObject.Find("Main Camera").transform.position.x, GameObject.Find("Main Camera").transform.position.y+2, -1);
            //transform.Translate(xPosition, yPosition, -9);
            framesActive = 60;
            color.a = 0.0f;

        }
        ////THIS IS SUPER BUDGET dont look pls
        if (framesActive>0)
        {
            if (framesActive<51)
            {
                if (waited == false)
                {
                    player.SetAnim("ultimate");
                    waited = true;
                }
            }
            if (framesActive>30)
            {
                GameObject.Find("Persona").transform.position = new Vector2(GameObject.Find("Player").transform.position.x + 2f, GameObject.Find("Player").transform.position.y - 1f);
                
            }
            else
            {
                GameObject.Find("Persona").transform.position = new Vector2(100, 100);
            }
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

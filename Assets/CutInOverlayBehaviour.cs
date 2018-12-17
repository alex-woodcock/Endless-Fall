using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInOverlayBehaviour : MonoBehaviour {
    /*
    GameObject.Find("cutIn").GetComponent<CutInBehaviour>();
    */
    SpriteRenderer m_SpriteRenderer;
    public Color color = new Color(0.390f, 0.367f, 0.770f, 0.473f);
    public int framesActive = 0;
    public GameObject cutInOverlay;
    // Use this for initialization
    void Start () {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		framesActive = GameObject.Find("cutIn").GetComponent<CutInBehaviour>().framesActive;
        
        
        if (framesActive>0)
        {
            Instantiate(cutInOverlay);
            //Destroy(cutInOverlay, 2);
            if (framesActive > 40)
            {
                color.a = 0.473f;
            }
            else if (framesActive < 21)
            {
                //color.a = color.a - (0.473f/20);
            }
        }
        else
        {
            color.a = 0f;
        }
        m_SpriteRenderer.color = color;
    }
}

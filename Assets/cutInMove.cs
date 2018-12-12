using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutInMove : MonoBehaviour {
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
    public void CutIn(int framesActive, int xPosition, int yPosition, float i)
    {
        //CutIn.SetActive(true);

        while (framesActive > 0)
        {
            //Wait(1);
            StartCoroutine(Wait(1));
            if (i * i / 10f > 0.05f)
            {
                transform.Translate(i * i / 10f, 0, 0);
            }

            framesActive--;
            i = i + 0.05f;
        }

    }
	// Use this for initialization
	void Start () {
		//go to the x y coords
	}
	
	// Update is called once per frame
	void Update () {
	}
}

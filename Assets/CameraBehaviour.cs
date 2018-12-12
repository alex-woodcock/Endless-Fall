using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {
    float yOffset = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(GameObject.Find("Player").transform.position);
        //Debug.Log(this.transform.position.x);
        yOffset= GameObject.Find("Player").GetComponent<PlayerBehaviour>().yOffset;
        this.transform.position = new Vector3(transform.position.x, GameObject.Find("Player").transform.position.y+yOffset, transform.position.z);
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(0, -2, 0);
            //yOffset += 0.2f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(0, 2, 0);
            //yOffset -= 0.2f;
        }
    }
}

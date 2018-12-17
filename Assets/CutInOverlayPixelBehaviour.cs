using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInOverlayPixelBehaviour : MonoBehaviour {
    //Random.Range(-1f, 1f);
    float yOffset = 0;
    void Start () {
        yOffset = Random.Range(-1f, 1f);
        transform.position = new Vector2(GameObject.Find("cutIn").transform.position.x - 2, GameObject.Find("cutIn").transform.position.y + yOffset);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = new Vector2(this.transform.position.x+0.8f, GameObject.Find("cutIn").transform.position.y+yOffset);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.acceleration.x, 0, 0);

        if (transform.position.x <= -8.09f)
            transform.position = new Vector3(-8.09f, transform.position.y, transform.position.z);
        else if (transform.position.x >= 8.03f)
            transform.position = new Vector3(8.03f, transform.position.y, transform.position.z);
    }
}

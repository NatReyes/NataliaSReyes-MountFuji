using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMotion : MonoBehaviour {
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(0, -speed, 0);
	}
}

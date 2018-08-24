using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {


    public float speed = 0.3f;

	
	void Update ()
    {
        transform.Rotate(speed, speed, speed);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class Movement : MonoBehaviour
{

    public float speed = 0.6f;
    public float gravity = -9.8f;

    private CharacterController _charController;

	// Use this for initialization
	void Start ()
    {
        _charController = GetComponent<CharacterController>();    
	}
	
	// Update is called once per frame
	void Update ()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;	
	}
}

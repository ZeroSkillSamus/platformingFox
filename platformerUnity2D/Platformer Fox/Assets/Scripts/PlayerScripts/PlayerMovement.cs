﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;

	public Transform target;
	public checkOnNPCActivity testNPC;

	private Animator anim;
	private Rigidbody2D rb;
	public bool allowJump;
	public bool allowCrouch;

	private bool cutScene;

	public Joystick joyStick;

	public GameObject checkIfGrounded;
	public GameObject triggerObject;

	float horizontalMove = 0f;
	public float runSpeed = 40f;
	public GameObject npc1;

	bool jump = false;
	bool crouch = false;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		cutScene = true;
	}

	public void setCutScene(bool cutscene)
	{
		this.cutScene = cutscene;
	}

	public bool getCutScene()
	{
		return this.cutScene;
	}
	// Update is called once per frame
	void Update () 
	{

		/*
		 * Right on keyboard equals 1 (D)
		 * Left on keyboard equals -1 (A)
		*/
		//This is for keyboard
		if (cutScene == false && npc1.active == false) {
			
			//horizontalMove = joyStick.Horizontal * runSpeed;
			horizontalMove = Input.GetAxisRaw ("Horizontal") * runSpeed;
			anim.SetFloat ("speed", Mathf.Abs (horizontalMove));
		} 
		if (npc1.active == false) {
			Debug.Log ("test");
			rb.constraints = RigidbodyConstraints2D.FreezeRotation;
		}

		//this means that the player might have fallen off of a cliff
			if (controller.m_Grounded == false && jump == false) {
				anim.SetBool ("isFalling", true);
			} else {
				anim.SetBool ("isFalling", false);
			}

		//restricts the person from jumping until they reach the certain tutorial guy
		if (allowJump == true) 
		{
			if (Input.GetButtonDown ("Jump")) {
				anim.SetBool ("isJumping", true);
				jump = true;
			}
		}
	
		//restricts the player from crouching until they reach the certain part of tutorial
		if (allowCrouch == true) 
		{
			if (Input.GetButtonDown ("Crouch") && anim.GetBool ("isJumping") == false) 
			{
				crouch = true;
			} else if (Input.GetButtonUp ("Crouch"))
			{
				crouch = false;
			}
		}

	

	}

	public void onCrouching(bool isCrouching)
	{
		anim.SetBool ("isCrouching", isCrouching);
	}
	public void onLanding()
	{
		//Debug.Log ("ss");
		anim.SetBool ("isJumping", false);

	}

	void FixedUpdate()
	{
		
		//Move the character here instead of doing it in void Update()
		//Time.fixedDeletaTime make sure the fox is moved the same amount no matter how many
		//times this function is called
		controller.Move (horizontalMove * Time.fixedDeltaTime,crouch,jump);
	    
		jump = false;
	}
		
	//Checks to see if player is on the platform
	//if it is then the player will stay on the platform
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.transform.tag == "MovingPlatform") 
		{
			transform.parent = col.transform;
		}

		if (col.transform.tag == "tutorialTrigger") 
		{
			triggerObject.SetActive (false);
		}
	}

	//Checks to see if the player has exited the platform
	//if the player is off sets the transform.parent = null
	//which stops the player from moving along with platform
	void OnCollisionExit2D(Collision2D col)
	{
		if (col.transform.tag == "MovingPlatform") 
		{
			transform.parent = null;
		}
	}
}

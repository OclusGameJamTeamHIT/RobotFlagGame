﻿using UnityEngine;
using System.Collections;

public class CharaCtrl2 : MonoBehaviour {
    private Vector3 vel = Vector3.zero;
    private CharacterController col;

    // Use this for initialization
    void Start()
    {
        col = (CharacterController)GetComponent("CharacterController");
    }

    //void Update()
    //{
    //    if (Input.GetKey("space"))
    //    {
            
    //    }
    //    if (Input.GetKey("e"))
    //    {
    //        col.SimpleMove(new Vector3(1, 0));
    //    }
    //    if (Input.GetKey("d"))
    //    {
    //        col.SimpleMove(new Vector3(-1, 0));
    //    }
    //    if (Input.GetKey("f"))
    //    {
            
    //    }
    //    if (Input.GetKey("s"))
    //    {
           
    //    } 
    //}

    void FixedUpdate()
    {
        /*
        // 落下
        vel.y += Physics.gravity.y * Time.fixedDeltaTime;
        col.Move(vel * Time.fixedDeltaTime);

        // 着地していたら速度を0にする
        if (col.isGrounded)
        {
            vel.y = 0;
        }
        */

        if (Input.GetKey("space")) {
			//transform.position += transform.forward * 0.01f;
			Vector3 vec = new Vector3(10,0,0);
			this.GetComponent<Rigidbody> ().AddForce (Vector3.up * 50);
		} 
		if (Input.GetKey("e")) {
			//transform.position += transform.forward * 0.01f;
			
            //Vector3 vec = new Vector3(10,0,0);
			//this.GetComponent<Rigidbody> ().AddForce (Vector3.forward * 10);

            transform.position += transform.forward * 0.10f; // 移動
		} 
		if (Input.GetKey("d")) {
			////transform.position += transform.forward * 0.01f;
			//Vector3 vec = new Vector3(10,0,0);
			//this.GetComponent<Rigidbody> ().AddForce (Vector3.back * 10);

            transform.position += transform.forward * -0.10f; // 移動
		} 
		if (Input.GetKey("f")) {
			//transform.position += transform.forward * 0.01f;
			Vector3 vec = new Vector3(10,0,0);
			this.GetComponent<Rigidbody> ().AddForce (Vector3.right * 10);
		} 
		if (Input.GetKey("s")) {
			//transform.position += transform.forward * 0.01f;
			Vector3 vec = new Vector3(10,0,0);
			this.GetComponent<Rigidbody> ().AddForce (Vector3.left * 10);
		} 
    }
}

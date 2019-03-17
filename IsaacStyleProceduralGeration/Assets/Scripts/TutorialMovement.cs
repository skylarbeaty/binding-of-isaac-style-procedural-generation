using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialMovement : MonoBehaviour {
	Vector3 moveJump = Vector2.zero;
	float horMove, vertMove;
	void Start(){
		SheetAssigner SA = FindObjectOfType<SheetAssigner>();
		Vector2 tempJump = SA.roomDimensions + SA.gutterSize;
		moveJump = new Vector3(tempJump.x, tempJump.y, 0); //distance b/w rooms: to be used for movement
	}
	void Update()
	{
		if (Input.GetKeyDown("w") || Input.GetKeyDown("s") || 
			Input.GetKeyDown("a") || Input.GetKeyDown("d")) //if any 'wasd' key is pressed
		{
			horMove = System.Math.Sign(Input.GetAxisRaw("Horizontal"));//capture input
			vertMove = System.Math.Sign(Input.GetAxisRaw("Vertical"));
			Vector3 tempPos = transform.position;
			tempPos += Vector3.right * horMove * moveJump.x; //jump bnetween rooms based opn input
			tempPos += Vector3.up * vertMove * moveJump.y;
			transform.position = tempPos;
		}
	}
}

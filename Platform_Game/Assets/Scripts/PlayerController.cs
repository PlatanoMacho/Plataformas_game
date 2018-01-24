using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
//	private Rigidbody rigidbody;

	private Vector3[] direction = {Vector3.forward, Vector3.right, Vector3.back,Vector3.left}; 
	private int currentDir;
	private bool vertical;

	// Use this for initialization
	void Start () {
//		rigidbody = GetComponent<Rigidbody>();
		currentDir = 0;
		
		//Debug.Log("Screen width " + screen_width);
		vertical = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		//rigidbody.AddForce(direction[currentDir] * speed * Time.deltaTime);
		transform.position += direction[currentDir] * speed * Time.deltaTime;
	}

	public void setCurrentDir(int dir){
		currentDir = dir;
	}

	public void setVertical(bool value){
		vertical = value;
	}
	public bool getVertical(){
		
		return vertical;
	}

}

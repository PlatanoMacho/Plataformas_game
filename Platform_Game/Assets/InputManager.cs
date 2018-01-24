using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InputManager : MonoBehaviour {

	public PlayerController player;

	private int screen_width;
	private Image arrow_Screen_L;
	private Image arrow_Screen_R;
	public Sprite arrow_left;
	public Sprite arrow_right;
	public Sprite arrow_up;
	public Sprite arrow_down;

	// Use this for initialization
	void Start () {
		screen_width = Screen.width;
		arrow_Screen_L = GameObject.Find("Arrow_Left").GetComponent<Image>();
		arrow_Screen_R = GameObject.Find("Arrow_Right").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Vector3 click_position = Input.mousePosition;
			
			if(click_position.x >= screen_width/2){
				if(player.getVertical()){
					player.setCurrentDir(1);
					player.setVertical(false);
				}
				else{
					player.setCurrentDir(0);
					player.setVertical(true);
				}
			}
			else{
				if(player.getVertical()){
					player.setCurrentDir(3);
					player.setVertical(false);
				}
				else{
					player.setCurrentDir(2);
					player.setVertical(true);
				}
			}
		}

		if(player.getVertical()){
			arrow_Screen_L.sprite = arrow_left;
			arrow_Screen_R.sprite = arrow_right;
		}
		else{
			arrow_Screen_L.sprite = arrow_down;
			arrow_Screen_R.sprite = arrow_up;
		}
	}

	public void clickButton(){
		player.transform.position = Vector3.up;
	}
}

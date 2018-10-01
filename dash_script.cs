// add 2d rigid body
//set collision detection to continous
//2d box collider
//from blackthornprod  https://www.youtube.com/watch?v=w4YV8s9Wi3w


// remove '// //' to enable separate code sections

using System.Collections;
using System.Collections.Generic;
using Unityengine;

public class dash_script : MonoBehaviour {
	private Rigidbody2D rb;
	public float dashSpeed;
	private float dashTime;
	
	public float startDashTime;
	private int direction;
	
// //	public GameObject DashEffect;
// 	particle system for effect
	
	void Start(){
		rb = GetComponent<Rigidbody2D>():
		dashTime = startDashTime
		
	}
	
	
	void Update(){
		
		if(direction == 0){
			if(Input.GetKeyDown(KeyCode.LeftArrow)){
			Instantiate(DashEffect,transform.position,Quaternion.identify);
				direction = 1;
			} else if (Input.GetKeyDown(KeyCode.RightArrow){
			Instantiate(DashEffect,transform.position,Quaternion.identify);
				direction = 2;
			} else if (Input.GetKeyDown(KeyCode.UpArrow)){
			Instantiate(DashEffect,transform.position,Quaternion.identify);
				direction = 3;
			} else if (Input.GetKeyDown(KeyCode.DownArrow)){
			Instantiate(DashEffect,transform.position,Quaternion.identify);
				direction = 4;
			}
			
			
		} else {
			if(dashTime <= 0){
				direction = 0;
				dashTime = startDashTime;
				rb.velocity = Vector2.zero;
			} else {
				dashTime -= Time.deltaTime;
	//			camAnim.SetTrigger("shake");
				
				
				if (direction == 1){
					rb.velocity = Vector2.left * dashSpeed;
				} else if (direction = 2)
				{
					rb.velocity  = Vector2.right * dashSpeed;
				} else if (direction = 3){
					rb.velocity = Vector2.up * dashSpeed;
				} else if (direction = 4){
					rb.velocity = Vector2.down * dashSpeed;
				}
				
			
			
		}
		
	}
	
}
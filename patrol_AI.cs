using System.Collections;
using System.Collections.Generic;
using Unityengine;

public class patrol_AI : Monobehaviour{
	public float speed;
	
	private bool movingRight = true;
	
	public Transform groundDetection;
	
	// empty gameobject placed infront of character
	
	void Update(){
		transform.Translate(Vector2.right * speed * Time.deltaTime);
		Raycasthit2D groundinfo = Physics2D.Raycast(groundDetection.position,Vector2.down,2f);
		
		if(groundinfo.collider == false){
			if(movingRight == true){
				transform.eulerAngles = new Vector3(0,180,0);
				movingRight = false;
			}else{
				transform.eulerAngles = new Vector3(0,0,0);
				movingRight = true;
			}
		}
		
	}
	
	
}
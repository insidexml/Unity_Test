using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {

	public float speed;
	public GUIText countText;
	public GUIText winText;
	private int count;

	void Start(){
		count = 0;
		setCountText ();
		winText.text = "";
	}
	/*void Update (){		//called before rendering a frame - for game code

	}*/

	void FixedUpdate(){	//called before physics calculations
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "PickUp") {
			other.gameObject.SetActive (false);
			count++;
			setCountText ();
		}
	}

	void setCountText(){
		countText.text = "Count: " + count.ToString();
		if (count >= 12) {
			winText.text = "You Win!";
		}
	}
}

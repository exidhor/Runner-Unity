using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speedX;
	public float speedY;
	public Text speed;
	public Text youLoose;
	public Text distanceText;
	public int distance;

	public bool isSpacePressed;

	private Rigidbody rigidBody;
	private float offset;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
		youLoose.text = "";
		setSpeedText ();

		offset = -rigidBody.position.z; 
		setDistanceText ();
	}
	
	// Update is called once per frame
	void Update () {
		setSpeedText ();
		setDistanceText ();
	}

	void FixedUpdate(){
		//deplacement
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal*speedX, 0, moveVertical*speedY);

		rigidBody.AddForce(movement*Time.deltaTime);

		// test de fin de jeu
		if (rigidBody.position.y < -5) {
			youLoose.text = "You Lose N00b !";
		}
	}

	void setSpeedText()
	{
		speed.text = "Speed : " + (int)(rigidBody.velocity.z);
	}

	void setDistanceText()
	{
		distance = (int)(rigidBody.position.z + offset);
		distanceText.text = "Distance : " + distance;

	}
		
}

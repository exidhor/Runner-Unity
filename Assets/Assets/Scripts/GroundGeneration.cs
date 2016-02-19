using UnityEngine;
using System.Collections;

public class GroundGeneration : MonoBehaviour {

	public Transform ground1;
	public Transform ground2;

	public Transform level1;
	public Transform level2;

	public Transform player;

	// Use this for initialization
	void Start () {
		
	}

	void Update()
	{
		if (player.position.z - 275 > ground1.position.z) {
			Vector3 movement = new Vector3 (0, 0, 1000);
			level1.position += movement;
		}
		if (player.position.z - 275 > ground2.position.z) {
			Vector3 movement = new Vector3 (0, 0, 1000);
			level2.position += movement;
		}
	}
}

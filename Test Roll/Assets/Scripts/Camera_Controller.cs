using UnityEngine;
using System.Collections;

public class Camera_Controller : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Best for procedural animation using last-known states
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}

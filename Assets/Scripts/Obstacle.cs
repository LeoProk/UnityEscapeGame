using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
	private Vector2 velocity = new Vector2(-4, 0); 
	private GameObject original;
	private int score;
	// Use this for initialization
	void Start()
	{
		GetComponent<Rigidbody2D>().velocity = velocity;
		transform.position = new Vector3(transform.position.x, transform.position.y -  Random.value, transform.position.z);
	}

	void Update() {
		if (GameObject.Find("firePairs" + "(Clone)").transform.position.x < -13) {
			score++;
			Destroy (GameObject.Find("firePairs" + "(Clone)"));
		}

	}
	// Update is called once per frame
	void OnGUI () 
	{
		GUI.color = Color.black;
		GUILayout.Label(" Score: " + score.ToString());
	} 
}
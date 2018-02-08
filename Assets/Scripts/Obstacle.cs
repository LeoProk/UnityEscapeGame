using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
	public Vector2 velocity = new Vector2(-4, 0);

	// Use this for initialization
	void Start()
	{
		rigidbody2D.velocity = velocity;
	}
}
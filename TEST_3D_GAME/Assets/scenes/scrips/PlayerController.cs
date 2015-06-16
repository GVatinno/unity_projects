using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void Update()
	{

	}

	void FixedUpdate()
	{
		float x = Input.GetAxis("Horizontal") * 2.5f;
		float y = Input.GetAxis("Vertical") * 2.5f;

		rb.AddForce ( x, 0.0f, y);

	}
}
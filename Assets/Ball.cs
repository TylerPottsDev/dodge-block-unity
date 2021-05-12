using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float speed = 3f;

	[SerializeField] Rigidbody2D rb;

	private void FixedUpdate() {
		rb.velocity = -transform.up * speed;
	}
}

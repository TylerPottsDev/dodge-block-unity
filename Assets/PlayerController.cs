using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
	[SerializeField] Transform[] lanes;
	int currentLane = 0;
	[SerializeField] LevelManager levelManager;

	private void Update() {
		if (Input.GetKeyDown(KeyCode.A) && currentLane > 0) {
			currentLane--;
			transform.position = new Vector2(lanes[currentLane].position.x, transform.position.y);
		}
		
		if (Input.GetKeyDown(KeyCode.D) && currentLane < lanes.Length - 1) {
			currentLane++;
			transform.position = new Vector2(lanes[currentLane].position.x, transform.position.y);
		}
	}

	private void OnCollisionEnter2D(Collision2D other) {
		levelManager.GameOver();
	}

}

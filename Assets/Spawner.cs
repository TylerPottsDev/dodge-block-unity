using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    
	[SerializeField] GameObject ballPrefab;
	[SerializeField] Transform[] laneSpawns;

	[SerializeField] LevelManager levelManager;

	[SerializeField] float gameAcceleration = 20f;
	[SerializeField] float spawnSpeed = 3f;
	[SerializeField] float minSpawnSpeed = 0.5f;
	float timer;
	float initialSpeed;

	private void Start() {
		timer = spawnSpeed;
		initialSpeed = spawnSpeed;
	}

	private void Update() {
		if (levelManager.isPlaying) {
			timer -= Time.deltaTime;

			if (timer < 0f) {
				timer = spawnSpeed;

				SpawnBall();
			}

			if (spawnSpeed > minSpawnSpeed) {
				spawnSpeed -= Time.deltaTime / gameAcceleration;
			} else if (spawnSpeed < minSpawnSpeed) {
				spawnSpeed = minSpawnSpeed;
			}
		}
	}

	void SpawnBall() {
		Transform lane = laneSpawns[Random.Range(0, laneSpawns.Length)];

		GameObject ball = Instantiate(ballPrefab, lane.position, Quaternion.identity);
		Ball ballScript = ball.GetComponent<Ball>();
		ballScript.speed += initialSpeed - spawnSpeed;
		Debug.Log(ballScript.speed); 
	}

}

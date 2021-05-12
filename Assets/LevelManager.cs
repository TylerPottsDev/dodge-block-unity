using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManager : MonoBehaviour {
    public float timeAlive = 0f;
	public bool isPlaying = true;
	[SerializeField] TextMeshProUGUI timeAliveGUI; 

	[SerializeField] GameObject gameOverPanel;

	private void Update() {
		if (isPlaying) {
			timeAlive += Time.deltaTime;
		}
	}

	public void GameOver () {
		gameOverPanel.SetActive(true);
		isPlaying = false;
	}

	private void OnGUI() {
		timeAliveGUI.text = Mathf.FloorToInt(timeAlive) + "s";
	}

	public void Reload() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}

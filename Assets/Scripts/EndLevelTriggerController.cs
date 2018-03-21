using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelTriggerController : MonoBehaviour {

	public bool gameOver;

	private EndGameDialogueSystem endGameDialogueSystem;

	// Use this for initialization
	void Start () {
		gameOver = false;
		endGameDialogueSystem = GetComponent<EndGameDialogueSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver) {
			print ("Game Over");
		}
	}

	public void SetGameOver(bool value) {
		gameOver = value;
	}

	public void ShowDialogue() {
		endGameDialogueSystem.Show ();
		endGameDialogueSystem.DisplayDialogue (1);
	}
}

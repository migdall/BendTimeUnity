using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlaySceneQuitButton : MonoBehaviour {

	private Button quitButton;

	// Use this for initialization
	void Start () {
		quitButton = GetComponent<Button> ();
		quitButton.gameObject.SetActive (false);
		quitButton.onClick.AddListener (delegate {
			CallMainMenuScene ();
		});
	}
	
	// Update is called once per frame
	void CallMainMenuScene () {
		if (quitButton.isActiveAndEnabled) {
			SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
		}
	}
}

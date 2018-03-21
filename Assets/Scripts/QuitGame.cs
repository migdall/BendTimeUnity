using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class QuitGame : MonoBehaviour {

	private Button quitButton;

	// Use this for initialization
	void Awake () {
		quitButton = GetComponent<Button> ();
		quitButton.onClick.AddListener (delegate {
			Quit ();
		});
	}

	// Update is called once per frame
	void Quit () {
		Application.Quit ();
	}
}

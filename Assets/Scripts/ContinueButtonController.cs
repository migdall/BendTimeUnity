using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButtonController : MonoBehaviour {

	public Text dialogueText;

	private Button continueButton;
	private int dialogueTextSequence = 1;

	// Use this for initialization
	void Awake () {
		continueButton = GetComponent<Button> ();
		continueButton.onClick.AddListener (delegate {
			dialogueTextSequence += 1;
			if (dialogueTextSequence == 2) {
				SetNewIntroText("Move me to the right with the right arrow key.");
			} else if (dialogueTextSequence == 3) {
				SetNewIntroText("Press SpaceBar to use turbo mode.");
			} else {
				SetNewIntroText("");
			}
		});
	}

	// Update is called once per frame
	void SetNewIntroText (string textValue) {
		dialogueText.text = textValue;
	}
}

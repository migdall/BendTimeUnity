using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameDialogueSystem : MonoBehaviour {

	public GameObject dialoguePanel;
	public string actorName;

	public string introDialogueText;

	private Button continueButton;
	private Text dialogueText;
	private Text nameText;
	private Image dialogueBox;
	private int dialogueIndex = 1;

	// Use this for initialization
	void Awake () {
		dialogueBox = dialoguePanel.transform.Find ("DialogueBox").GetComponent<Image> ();
		nameText = dialogueBox.transform.Find ("Name").GetComponent<Text>();
		dialogueText = dialogueBox.transform.Find ("Text").GetComponent<Text> ();

		continueButton = dialogueBox.transform.Find ("ContinueButton").GetComponent<Button> ();
		continueButton.onClick.AddListener (delegate {
			dialogueIndex += 1;
			DisplayDialogue(0);
		});
	}

	void Start () {
		nameText.text = actorName;
		dialogueText.text = introDialogueText;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DisplayDialogue (int index) {
		if (index > 0) {
			if (index == 1) {
				dialogueText.text = introDialogueText;
			} else {
				dialoguePanel.SetActive (false);
			}
		} else {
			if (dialogueIndex == 1) {
				dialogueText.text = introDialogueText;
			} else {
				dialoguePanel.SetActive (false);
			}
		}
	}

	public void Show() {
		dialoguePanel.SetActive (true);
	}

	public void Hide() {
		dialoguePanel.SetActive (false);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour {

	public GameObject dialoguePanel;
	public string actorName;

	public string introDialogueText;
	public string basicMovementDialogueText;
	public string boostMovementDialogueText;
	public string endGameDialogueText;

	public bool gameOver;

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
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DisplayDialogue (int index) {
		if (!dialoguePanel.activeSelf) {
			dialoguePanel.SetActive (true);
		}
	
		if (index > 0) {
			if (index == 1) {
				dialogueText.text = introDialogueText;
			} else if (index == 2) {
				dialogueText.text = basicMovementDialogueText;
			} else if (index == 3) {
				dialogueText.text = boostMovementDialogueText;
			} else if (index == 4 && gameOver) {
				dialogueText.text = endGameDialogueText;
			} else {
				dialoguePanel.SetActive (false);
			}
		} else {
			if (dialogueIndex == 1) {
				dialogueText.text = introDialogueText;
			} else if (dialogueIndex == 2) {
				dialogueText.text = basicMovementDialogueText;
			} else if (dialogueIndex == 3) {
				dialogueText.text = boostMovementDialogueText;
			} else if (index == 4 && gameOver) {
				dialogueText.text = endGameDialogueText;
			} else {
				dialoguePanel.SetActive (false);
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float maxSpeed;
	public float timeZeroToMax;

	public Button quitButton;

	private bool isMaxSpeed;
	private bool isEnd;
	private Transform tf;

	private DialogueSystem playerDialogue;

	void Start ()
	{
		tf = GetComponent<Transform> ();
		isMaxSpeed = false;
		speed = 0.15f;
		maxSpeed = 2.15f;
		timeZeroToMax = 0.5f;
		isEnd = false;
		playerDialogue = GameObject.Find ("BenDialogueSystem").transform.GetComponent<DialogueSystem>();
	}

	void Update()
	{
		if (Input.GetKeyDown ("space")) {
			isMaxSpeed = true;
		} else if (Input.GetKeyUp ("space")) {
			isMaxSpeed = false;
		}
	}

	void FixedUpdate ()
	{
		if (!isEnd) {
			float moveHorizontal = Input.GetAxis ("Horizontal");

			if (isMaxSpeed) {
				tf.Translate (-moveHorizontal * maxSpeed, 0f, 0f);
			} else {
				tf.Translate (-moveHorizontal * speed, 0f, 0f);
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("End")) {
			isEnd = true;
			// quitButton.enabled = true;
			// quitButton.gameObject.SetActive (true);
			// other.gameObject.transform.GetComponent<EndLevelTriggerController>().SetGameOver(true);
			// other.gameObject.transform.GetComponent<EndLevelTriggerController> ().ShowDialogue ();
			playerDialogue.gameOver = true;
			playerDialogue.DisplayDialogue(4);
		}
	}
}

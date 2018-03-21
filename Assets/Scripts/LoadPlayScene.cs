using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadPlayScene : MonoBehaviour {

	private Button playButton;

	// Use this for initialization
	void Awake () {
		playButton = GetComponent<Button> ();
		playButton.onClick.AddListener (delegate {
			PlayScene ();
		});
	}
	
	// Update is called once per frame
	void PlayScene () {
		SceneManager.LoadScene ("Play", LoadSceneMode.Single);
	}
}

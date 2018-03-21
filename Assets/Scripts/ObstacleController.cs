using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {

	public float moveTime;
	public float deltaMoveTime;
	public float zTranslation;

	private float originalMoveTime;
	private float originalDeltaMoveTime;

	private Transform tf;

	void Start ()
	{
		tf = GetComponent<Transform> ();
		originalMoveTime = moveTime;
		originalDeltaMoveTime = deltaMoveTime;
	}

	void Update ()
	{
		moveTime -= Time.deltaTime;

		if (moveTime < 0) {
			if (deltaMoveTime < 0) {
				moveTime = originalMoveTime;
				deltaMoveTime = originalDeltaMoveTime;
				tf.position = new Vector3 (29.47f, 5f, -18.4f);
			} else {
				deltaMoveTime -= Time.deltaTime;
				tf.Translate(0f, 0f, zTranslation);
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			print ("I've been hit");
		}
	}
}

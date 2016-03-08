using UnityEngine;
using System.Collections;


public class Coin : MonoBehaviour {

	public bool isFree;
	public ScoreManager scoremanager;

	void Start () {
		isFree = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isFree) {
			Destroy (gameObject);
		}

	}void OnTriggerEnter (Collider other){
		scoremanager.AddPoints(1);
		isFree = false;
	}
}

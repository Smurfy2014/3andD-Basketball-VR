﻿using UnityEngine;
using System.Collections;

public class GoalConfirm : MonoBehaviour {

	Collider expectedCollider;

	public void ExpectCollider(Collider collider){
		expectedCollider = collider;
	}

	void OnTriggerEnter(Collider otherCollider){
		if (otherCollider == expectedCollider){
			ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper> ();
			scoreKeeper.IncrementScore(1);
		}
	}
}
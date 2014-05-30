﻿using UnityEngine;
using System.Collections;

public class L1CommentSetter : MonoBehaviour {

	string tracing = "//To Find average of forces acting on the body in one dimension" +
				"\n//Input : Integer numbers (any unit of measurement) " +
				"\n//Output: Average force on body (same units)";
			

	// Use this for initialization
	void Start () {
		TextMesh Tm = GetComponent<TextMesh>();
		Tm.text = tracing;	
		Tm.color = Color.gray;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
﻿using UnityEngine;
using System.Collections;

public class sidebarbug3 : MonoBehaviour {

	public GameObject level;
	int levelnum;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		levelnum = System.Convert.ToInt16(level.GetComponent<TextMesh> ().text);
		GUITexture img = GetComponent<GUITexture> ();
		if (levelnum == 3) {
				img.enabled = true;
				} else {
				img.enabled = false;
				}
					
	
	}
}
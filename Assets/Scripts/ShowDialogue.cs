﻿using UnityEngine;
using System.Collections;

public class ShowDialogue : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        GameObject dialogue = this.transform.Find("DialoguePrefab").gameObject;
        dialogue.SetActive(true);

    }
}

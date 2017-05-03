﻿using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
	[SerializeField]
	private KeyCode TabKey;
	[SerializeField]
	private KeyCode UpKey;
	[SerializeField]
	private KeyCode DownKey;
	[SerializeField]
	private KeyCode LeftKey;
	[SerializeField]
	private KeyCode RightKey;

	public delegate void keyHandler(KeyCode keyPressed);
	public event keyHandler keyPressed;

	// Use this for initialization
	void Start () {
		StartCoroutine (PlayerInput ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnEnable () {
		PlayerInput ();
	}
	void OnDisable() {
		StopCoroutine (PlayerInput());
	}
	IEnumerator PlayerInput(){
		while (this == enabled) {
			//Debug.Log ("this is running");
			if (Input.GetKey (TabKey)) {
				Debug.Log ("got through");
				keyPressed (TabKey);
			} else if (Input.GetKey (UpKey)) {
				keyPressed (UpKey);
			} else if (Input.GetKey (DownKey)) {
				keyPressed (DownKey);
			} else if (Input.GetKey (LeftKey)) {
				keyPressed (LeftKey);
			} else if (Input.GetKey (RightKey)) {
				keyPressed (RightKey);
			}
			//Debug.Log ("running playerinput");
			yield return new WaitForSeconds(0.1f);
		}
	}
	public KeyCode GetTabKey()
	{
		return TabKey;
	}
	public KeyCode GetUpKey()
	{
		return UpKey;
	}
	public KeyCode GetDownKey()
	{
		return DownKey;
	}
	public KeyCode GetLeftKey()
	{
		return LeftKey;
	}
	public KeyCode GetRightKey()
	{
		return RightKey;
	}
}

using UnityEngine;
using System.Collections;

public class ExitDoor : MonoBehaviour {


	public bool open = false;

	// Use this for initialization
	void Start () {
		this.open = false;
		Debug.Log ("I'm a door, i'm " + open + "");
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Open () {
		this.open = true;
		animation.Play ("DoorAnim");
	}

	public void Close () {
		this.open = false;
		animation.Play ("DoorAnim");
	}

}

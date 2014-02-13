using UnityEngine;
using System.Collections;

public class helloworld : MonoBehaviour {
	
	string currentRoom = "lobby";
	
	// Use this for initialization
	void Start () {
		// if you see"//" that's a comment
		// instructions have to go inside functions
		Debug.Log ("Hello World");
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<TextMesh>().text = "Hola Mundo";
		
		if (currentRoom == "lobby") {
			GetComponent<TextMesh> ().text += "\nYou are in the lobby. \"Hey,\" says the guard.";
			GetComponent<TextMesh> ().text += "\nPress [F] to go to 511.";
			if (Input.GetKeyDown (KeyCode.F)) {
				currentRoom = "room511";
			}
		} else if (currentRoom == "room511") {
			GetComponent<TextMesh> ().text += "\nYou are at Building Worlds.";
			GetComponent<TextMesh> ().text += "\nPress [G] to go to my room.";
			if (Input.GetKeyDown (KeyCode.G)) {
				currentRoom = "myroom";
			}
		} else if (currentRoom == "myroom") {
			GetComponent<TextMesh> ().text += "\nsssssssssssss";
			
		}
	}
}
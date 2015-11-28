using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour {

	public string nextScene;
	// Use this for initialization
	void Start () {
	
	}

	void Update () {
		if (Input.GetKeyDown ("Submit")) {
			Application.LoadLevel ("nextScene");
		}
	}
}
              
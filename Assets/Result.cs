using UnityEngine;
using System.Collections;

public class Result : MonoBehaviour {
	public GameObject result;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		result.GetComponent<TextMesh> ().text = "RESULT";
	}
}

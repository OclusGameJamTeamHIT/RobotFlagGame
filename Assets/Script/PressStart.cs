using UnityEngine;
using System.Collections;

public class PressStart : MonoBehaviour {
    public GameObject press;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        press.GetComponent<TextMesh>().text = "PRESS START";
	}
}

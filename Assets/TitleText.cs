using UnityEngine;
using System.Collections;

public class TitleText : MonoBehaviour {
    public GameObject Title;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Title.GetComponent<TextMesh>().text = "RobotFlagGame";
	}
}

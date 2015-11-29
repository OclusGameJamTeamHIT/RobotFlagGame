using UnityEngine;
using System.Collections;

public class GameSceneChange : MonoBehaviour {
	public string nextsceneA;
	public GameObject RTime;
	// Use this for initialization
	void Start () {
		RTime = GameObject.Find ("TIME");
	}
	
	// Update is called once per frame
	void Update () {
		TIME tm = RTime.GetComponent<TIME> ();
		if(tm.hTime<=0){
			Application.LoadLevel (nextsceneA);
		}

	}
}

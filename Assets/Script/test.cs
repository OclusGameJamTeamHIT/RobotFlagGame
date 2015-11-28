using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
    public GameObject CB;
	// Use this for initialization
	void Start () {
      CB= GameObject.Find("Score");
	}
	
	// Update is called once per frame
	void Update () {
        SCORE sc = CB.GetComponent<SCORE>();
        sc.ScoreUp();
	}
}

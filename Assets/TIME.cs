using UnityEngine;
using System.Collections;

public class TIME : MonoBehaviour {
    public GameObject time;
    public float hTime;
    private int TimeFrame;
	// Use this for initialization
	void Start () {
        hTime = 60.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (TimeFrame > 60)
        {
            hTime--;
            TimeFrame = 0;
        }
        TimeFrame++;
        time.GetComponent<TextMesh>().text = "Time : " + hTime;
	}
}

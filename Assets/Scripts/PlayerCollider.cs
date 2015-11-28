using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {
	public GameObject SC;
	// Use this for initialization
	void Start () {
		SC = GameObject.Find("Score");
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other)
	{
		if(other.tag=="Coin")
			Destroy(other.gameObject);
		SCORE sc = SC.GetComponent<SCORE>();
		sc.ScoreUp();
		Debug.Log("当たったよ！");

	}
}

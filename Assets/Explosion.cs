using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	public GameObject Explo;
	public GameObject cu2;
	// Use this for initialization
	void Start () {
		cu2 = GameObject.Find ("005339_08932_-10752001");
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag=="Bullet")
		{
			Debug.Log ("爆発!");
			Instantiate (Explo,transform.position,transform.rotation);
			Destroy (cu2.gameObject);

		}

	}
}

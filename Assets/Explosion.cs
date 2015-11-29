using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	public GameObject Explo;
	public GameObject cu2;
	// Use this for initialization
	void Start () {
		cu2 = GameObject.Find ("Cube");
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag=="Bullet")
		{
			Instantiate (Explo,transform.position,transform.rotation);
			Destroy (cu2.gameObject);

		}

	}
}

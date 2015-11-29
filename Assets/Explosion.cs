using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	public GameObject Explo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag=="Bullet")
		{
			Instantiate (Explo,transform.position,transform.rotation);
			Destroy (this);

		}

	}
}

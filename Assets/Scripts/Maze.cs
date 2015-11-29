using UnityEngine;
using System.Collections;

public class Maze : MonoBehaviour {
	
	public GameObject Bullet;
	public GameObject Gun;
	public GameObject b2;
	Vector3 BulletDirection;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) 
		{
			Gun = GameObject.Find ("assault_mech_LeftArm");
			b2 = Instantiate (Bullet);
			Debug.Log ("弾のインスタンスをしました");
			b2.transform.position =Gun.transform.position;
			//b2.transform.rotation = Gun.transform.rotation;
			BulletDirection = (Gun.transform.position - this.transform.position).normalized;
				b2.GetComponent<Rigidbody>().velocity = BulletDirection * 50;
	}
}
}

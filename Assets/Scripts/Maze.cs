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
		if (Input.GetKeyDown (KeyCode.A)) {
			Gun = GameObject.Find ("assault_mech_LeftArmRocket");
			b2 = Instantiate (Bullet);
			Debug.Log ("弾のインスタンスをしました");
			b2.transform.position =Gun.transform.position;
			b2.transform.rotation = Gun.transform.rotation;
			BulletDirection = (this.transform.position - Gun.transform.position).normalized;
			if (Physics.Raycast (b2.transform.position, BulletDirection, 50.0f)) {
				b2.GetComponent<Rigidbody> ().velocity = BulletDirection * 50;
			} else {
				Debug.Log ("弾を削除します");
				//Destroy (b2.gameObject);
			}
		}
	}
}

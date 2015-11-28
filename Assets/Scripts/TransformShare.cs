using UnityEngine;
using System.Collections;

public class TransformShare : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
        //this.player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        //this.transform.rotation = new Quaternion(player.transform.rotation.x,
        //                                    player.transform.rotation.y,
        //                                    player.transform.rotation.z,
        //                                    player.transform.rotation.w);
	}
}

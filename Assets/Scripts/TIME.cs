using UnityEngine;
using System.Collections;

public class TIME : MonoBehaviour {
    public GameObject time;
    public float hTime;
    private int TimeFrame;
	// Use this for initialization
	void Start () {
        //Timeの初期値
        hTime = 60.0f;
	}
	
	// Update is called once per frame
	void Update () {
        //60fたったら
        if (TimeFrame > 60)
        {
            //時間を進める
            hTime--;
            TimeFrame = 0;
        }
        //フレームの増加処理
        TimeFrame++;
        //Timeの描画
        time.GetComponent<TextMesh>().text = "Time : " + hTime;
	}
}

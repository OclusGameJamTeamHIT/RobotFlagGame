using UnityEngine;
using System.Collections;

public class SCORE : MonoBehaviour {
    //スコアの描画をするクラス
    public GameObject g_Score;
    public GameObject g_flag;
    private static long score=0;
    private static long flagCount=0;

	// Use this for initialization
	void Start () {
        //スコアを初期値0に指定
       // score = 0;
       // flagCount = 0;
    }
	
	// Update is called once per frame
	void Update () {
        //スコア描画処理
        g_Score.GetComponent<TextMesh>().text = "score : " + score;
        g_flag.GetComponent<TextMesh>().text = "Flag : " + flagCount;
	}

    //スコアをアップする処理
    public void ScoreUp() {
        score+=1000;
        Debug.Log("スコアが増加しました");
    
    }
    //フラグを手に入れたら呼び出す関数
    public void FlagGet()
    {
        flagCount++;
        Debug.Log("フラグを獲得しました");
    }
}

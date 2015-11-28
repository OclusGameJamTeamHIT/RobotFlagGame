using UnityEngine;
using System.Collections;

public class SCORE : MonoBehaviour {
    //スコアの描画をするクラス
    public GameObject g_Score;
    public GameObject g_flag;
    private long score;
    private long flagCount;

	// Use this for initialization
	void Start () {
        //スコアを初期値0に指定
        score = 0;
        flagCount = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.C))
        {
            ScoreUp();
            FlagGet();
        }
        
        //スコア描画処理
        g_Score.GetComponent<TextMesh>().text = "score : " + score;
        g_flag.GetComponent<TextMesh>().text = "Flag : " + flagCount;
	}

    //スコアをアップする処理
    public long ScoreUp() {
        score+=1000;
        return score;
    }
    //フラグを手に入れたら呼び出す関数
    public long FlagGet()
    {
        flagCount++;
        return flagCount;
    }
}

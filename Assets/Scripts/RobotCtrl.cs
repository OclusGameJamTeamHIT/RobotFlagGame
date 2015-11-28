using UnityEngine;
using System.Collections;

public class RobotCtrl : MonoBehaviour {
    public GameObject camera1;
    private Animator animator;

    bool gameOver = false;

    // ジャンプする力
    //public float force = 5.0f;
    private int jumpCount = 0;
    const int MAX_JUMP_COUNT = 2;

    void Start()
    {
        animator = GetComponent<Animator>();
        gameOver = false;
    }

    void Update()
    {
        CameraCtrl camCtrl = camera1.GetComponent<CameraCtrl>();

        if (transform.position.y < 90.0f && !gameOver)
        {
            gameOver = true;
        }


        if (Input.GetKey("up"))
        {
            //transform.position += transform.forward * 0.10f; // 移動

            Vector3 vec = new Vector3(0, 0.0f, 5);
            this.GetComponent<Rigidbody>().AddForce(vec * 5, ForceMode.Impulse);
        }
        else if (Input.GetKey("right"))
        {
            Vector3 vec = new Vector3(10, 0.0f, 0);
            this.GetComponent<Rigidbody>().AddForce(vec * 5, ForceMode.Impulse);
        }
        else if (Input.GetKey("left"))
        {
            Vector3 vec = new Vector3(-10, 0.0f, 0);
            this.GetComponent<Rigidbody>().AddForce(vec * 5, ForceMode.Impulse);
        }
        else if (Input.GetKey("down"))
        {
            //transform.position += transform.forward * -0.10f; // 移動

            Vector3 vec = new Vector3(0, 0.1f, -5);
            this.GetComponent<Rigidbody>().AddForce(vec * 5, ForceMode.Impulse);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            if (jumpCount < MAX_JUMP_COUNT)
            {
                jumpCount++;
                this.GetComponent<Rigidbody>().AddForce(transform.up * 10, ForceMode.Impulse);

                Debug.Log("#### Jump");
                animator.SetBool("is_jumping", true);
            }
        }
        else
        {
            animator.SetBool("is_running", false);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            jumpCount = 0; // ジャンプ回数初期化
            animator.SetBool("is_jumping", false);

            Debug.Log("#### FloorCollision");
        }
    }
}

using UnityEngine;
using System.Collections;

public class RobotCtrl : MonoBehaviour {
    public GameObject camera;
    private Animator animator;
    bool gameOver = false;

    // ジャンプする力
    public float jumpforce = 1f;
    private int jumpCount = 0;
    const int MAX_JUMP_COUNT = 10;

    public float moveforce = 0.1f;

    void Start()
    {
        animator = GetComponent<Animator>();
        gameOver = false;
    }

    void Update()
    {
        CameraCtrl camCtrl = camera.GetComponent<CameraCtrl>();

        //if (transform.position.y < 90.0f && !gameOver)
        //{
        //    gameOver = true;
        //}


        if (Input.GetKey("up"))
        {
            //transform.position += transform.forward * 0.10f; // 移動

            Vector3 vec = new Vector3(0, 0.0f, -1);
            //this.GetComponent<Rigidbody>().AddForce(vec * moveforce, ForceMode.Impulse);
            this.GetComponent<Rigidbody>().AddForce(vec * moveforce * 10, ForceMode.Force);
            //this.GetComponent<Rigidbody>().AddForce(transform.up * jumpforce / 5, ForceMode.Impulse);

            //this.GetComponent<Rigidbody>().velocity = vec * moveforce;

            //this.GetComponent<Rigidbody>().AddExplosionForce(500.0f, new Vector3(0, 0.5f, 0), 10.0f);

            //testObj.GetComponent<Rigidbody>().AddForce(vec * moveforce, ForceMode.VelocityChange);
            //testObj.GetComponent<Rigidbody>().AddExplosionForce(500.0f, new Vector3(0, 0.5f, 0), 10.0f);
        }
        else if (Input.GetKey("right"))
        {
            Vector3 vec = new Vector3(-1, 0.0f, 0);
            this.GetComponent<Rigidbody>().AddForce(vec * moveforce * 10, ForceMode.Force);
            //this.GetComponent<Rigidbody>().velocity = transform.right.normalized * 50f;

            //this.GetComponent<Rigidbody>().AddForce(transform.up * jumpforce / 3, ForceMode.Impulse);
        }
        else if (Input.GetKey("left"))
        {
            Vector3 vec = new Vector3(1, 0.0f, 0);
            this.GetComponent<Rigidbody>().AddForce(vec * moveforce * 10, ForceMode.Force);
            //this.GetComponent<Rigidbody>().velocity = transform.right.normalized * -50f;

            //this.GetComponent<Rigidbody>().AddForce(transform.up * jumpforce / 3, ForceMode.Impulse);
        }
        else if (Input.GetKey("down"))
        {
            //transform.position += transform.forward * -0.10f; // 移動

            Vector3 vec = new Vector3(0, 0.0f, 1);
            this.GetComponent<Rigidbody>().AddForce(vec * moveforce * 10, ForceMode.Force);
            //this.GetComponent<Rigidbody>().velocity = transform.forward.normalized * -50f;

            //this.GetComponent<Rigidbody>().AddForce(transform.up * jumpforce / 3, ForceMode.Impulse);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            if (jumpCount < MAX_JUMP_COUNT)
            {
                jumpCount++;
                this.GetComponent<Rigidbody>().AddForce(transform.up * jumpforce, ForceMode.Impulse);

                Debug.Log("#### Jump");
                animator.SetBool("is_jumping", true);
            }
        }
        else
        {
            //animator.SetBool("is_running", false);
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

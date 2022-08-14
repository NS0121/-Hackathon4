using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //追加

public class Test_PlayerScript : MonoBehaviour
{
    [SerializeField] private int jumpCount = 0;
    [SerializeField] private int ResurrectCount = 0;
    [SerializeField] private float jumpPower = 0f;
    [SerializeField] private float moveSpeed = 0f;
    private bool IsJump = false;
    public bool IsSpawn = false;
    public static Test_PlayerScript instance;//テストプレイで変更中（追加はしない）

    static public bool Spawn = false;//追加　崩れる床を復活させるフラグ

    void Start()
    {
    }
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {
        Jump();
        Move();
        Resurrection();
    }

    #region 移動関連
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsJump)//(jumpCount > 0 && (IsJump)　//テストプレイで変更中（追加はしない）
            {
                jumpCount--;
                Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
                Vector3 force = new Vector3(0.0f, jumpPower, 0.0f);
                rb.AddForce(force);  // 力を加える
                IsJump = false;
            }
        }
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-moveSpeed, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(moveSpeed, 0.0f, -0.0f);
        }
    }
    #endregion

    #region イベント
    void Resurrection()
    {
        if (Input.GetKeyDown(KeyCode.E)) //&& ResurrectCount > 0)//テストプレイで変更中（追加はしない）
        {
            ResurrectCount--;
            IsSpawn = true;
        }
    }
    #endregion

    #region 接触判定
    void OnCollisionEnter(Collision collision)
    {
        IsJump = true;

        //ワープする床だった時
        if (collision.gameObject.name == "Warp_Ground")//追加
        {
            //現在の位置を取得
            Vector3 nowPos = transform.position;
            //プレイヤーを上に３移動
            transform.position = new Vector3(nowPos.x, nowPos.y + 3, nowPos.z);
        }
    }
    void OnTriggerEnter(Collider other) //追加
    {
        //ワープのオブジェクトに触れたらマップ２に移動
        if (other.gameObject.tag == "Warp")
        {
            SceneManager.LoadScene("Map2");
        }

        //ワープのオブジェクトに触れたらマップ２に移動
        if (other.gameObject.tag == "Warp" && other.gameObject.name == "Warp2")
        {
            SceneManager.LoadScene("Map3");
        }

        //ワープのオブジェクトに触れ・名前がWarp3だったらマップ２に移動
        if (other.gameObject.tag == "Warp" && other.gameObject.name == "Warp3")
        {
            Debug.Log("終わり");
        }

        //回復アイテムに触れたら
        if (other.gameObject.tag == "recovery")
        {
            ResurrectCount += 2;　//残機を2増やす
        }

        //敵の弾に当たったら残機を減らして、復活する
        if (other.gameObject.name == "Bullet(Clone)")
        {
            ResurrectCount--;
            IsSpawn = true;
        }
    }

    //画面外に出た時
    void OnBecameInvisible()//追加
    {
        ResurrectCount--;
        IsSpawn = true;
        Spawn = true;//追加 崩れる床を復活させる
    }
    #endregion
}

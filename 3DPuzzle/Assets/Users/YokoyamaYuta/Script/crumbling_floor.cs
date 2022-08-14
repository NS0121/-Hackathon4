using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crumbling_floor : MonoBehaviour
{
    public float Destroy_time = 0f;     //プレイヤーが崩れる床に乗ってる時間

    private bool annihilation = false;　//プレイヤーが崩れる床に乗っているかのフラグ

    void Update()
    {
        if (Destroy_time >= 1f)　//プライヤーが崩れる床に1秒以上乗っていたら
        {
            gameObject.SetActive(false);　//崩れる床を非表示
            Destroy_time = 0f;  //崩れる床に乗ってる時間を0にする
            annihilation = false;   //崩れる床に乗っているかのフラグをfalseにする
        }

        if (annihilation)   //プレイヤーが崩れる床に乗っていたら
        {
            Destroy_time += Time.deltaTime;
        }
    }

    //床に接している間
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            annihilation = true;　//崩れる床に乗っているかのフラグをtrueにする
        }
    }

    //床から離れたとき
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy_time = 0f;　　 //崩れる床に乗ってる時間を0にする
            annihilation = false;　//崩れる床に乗っているかのフラグをfalseにする
        }
    }
}

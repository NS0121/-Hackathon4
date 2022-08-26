using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    [SerializeField] GameObject Special_wall;  //ワープするオブジェクトの前のブロック

    void OnTriggerEnter(Collider other) //追加
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Special_wall.SetActive(false);　//ワープするオブジェクトの前のブロックが消える
        }
    }
}

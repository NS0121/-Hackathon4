using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recovery : MonoBehaviour
{
    void OnTriggerEnter(Collider other) //�ǉ�
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    [SerializeField] GameObject Special_wall;  //���[�v����I�u�W�F�N�g�̑O�̃u���b�N

    void OnTriggerEnter(Collider other) //�ǉ�
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Special_wall.SetActive(false);�@//���[�v����I�u�W�F�N�g�̑O�̃u���b�N��������
        }
    }
}

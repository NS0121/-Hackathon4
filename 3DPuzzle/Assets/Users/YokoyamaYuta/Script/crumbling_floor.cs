using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crumbling_floor : MonoBehaviour
{
    public float Destroy_time = 0f;     //�v���C���[������鏰�ɏ���Ă鎞��

    private bool annihilation = false;�@//�v���C���[������鏰�ɏ���Ă��邩�̃t���O

    void Update()
    {
        if (Destroy_time >= 1f)�@//�v���C���[������鏰��1�b�ȏ����Ă�����
        {
            gameObject.SetActive(false);�@//����鏰���\��
            Destroy_time = 0f;  //����鏰�ɏ���Ă鎞�Ԃ�0�ɂ���
            annihilation = false;   //����鏰�ɏ���Ă��邩�̃t���O��false�ɂ���
        }

        if (annihilation)   //�v���C���[������鏰�ɏ���Ă�����
        {
            Destroy_time += Time.deltaTime;
        }
    }

    //���ɐڂ��Ă����
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            annihilation = true;�@//����鏰�ɏ���Ă��邩�̃t���O��true�ɂ���
        }
    }

    //�����痣�ꂽ�Ƃ�
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy_time = 0f;�@�@ //����鏰�ɏ���Ă鎞�Ԃ�0�ɂ���
            annihilation = false;�@//����鏰�ɏ���Ă��邩�̃t���O��false�ɂ���
        }
    }
}

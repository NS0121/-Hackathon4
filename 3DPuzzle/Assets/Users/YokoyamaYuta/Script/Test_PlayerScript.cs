using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�ǉ�

public class Test_PlayerScript : MonoBehaviour
{
    [SerializeField] private int jumpCount = 0;
    [SerializeField] private int ResurrectCount = 0;
    [SerializeField] private float jumpPower = 0f;
    [SerializeField] private float moveSpeed = 0f;
    private bool IsJump = false;
    public bool IsSpawn = false;
    public static Test_PlayerScript instance;//�e�X�g�v���C�ŕύX���i�ǉ��͂��Ȃ��j

    static public bool Spawn = false;//�ǉ��@����鏰�𕜊�������t���O

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

    #region �ړ��֘A
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsJump)//(jumpCount > 0 && (IsJump)�@//�e�X�g�v���C�ŕύX���i�ǉ��͂��Ȃ��j
            {
                jumpCount--;
                Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody���擾
                Vector3 force = new Vector3(0.0f, jumpPower, 0.0f);
                rb.AddForce(force);  // �͂�������
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

    #region �C�x���g
    void Resurrection()
    {
        if (Input.GetKeyDown(KeyCode.E)) //&& ResurrectCount > 0)//�e�X�g�v���C�ŕύX���i�ǉ��͂��Ȃ��j
        {
            ResurrectCount--;
            IsSpawn = true;
        }
    }
    #endregion

    #region �ڐG����
    void OnCollisionEnter(Collision collision)
    {
        IsJump = true;

        //���[�v���鏰��������
        if (collision.gameObject.name == "Warp_Ground")//�ǉ�
        {
            //���݂̈ʒu���擾
            Vector3 nowPos = transform.position;
            //�v���C���[����ɂR�ړ�
            transform.position = new Vector3(nowPos.x, nowPos.y + 3, nowPos.z);
        }
    }
    void OnTriggerEnter(Collider other) //�ǉ�
    {
        //���[�v�̃I�u�W�F�N�g�ɐG�ꂽ��}�b�v�Q�Ɉړ�
        if (other.gameObject.tag == "Warp")
        {
            SceneManager.LoadScene("Map2");
        }

        //���[�v�̃I�u�W�F�N�g�ɐG�ꂽ��}�b�v�Q�Ɉړ�
        if (other.gameObject.tag == "Warp" && other.gameObject.name == "Warp2")
        {
            SceneManager.LoadScene("Map3");
        }

        //���[�v�̃I�u�W�F�N�g�ɐG��E���O��Warp3��������}�b�v�Q�Ɉړ�
        if (other.gameObject.tag == "Warp" && other.gameObject.name == "Warp3")
        {
            Debug.Log("�I���");
        }

        //�񕜃A�C�e���ɐG�ꂽ��
        if (other.gameObject.tag == "recovery")
        {
            ResurrectCount += 2;�@//�c�@��2���₷
        }

        //�G�̒e�ɓ���������c�@�����炵�āA��������
        if (other.gameObject.name == "Bullet(Clone)")
        {
            ResurrectCount--;
            IsSpawn = true;
        }
    }

    //��ʊO�ɏo����
    void OnBecameInvisible()//�ǉ�
    {
        ResurrectCount--;
        IsSpawn = true;
        Spawn = true;//�ǉ� ����鏰�𕜊�������
    }
    #endregion
}

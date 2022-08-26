using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public static PlayerStatus instance;

    [SerializeField]
    private float jumpPower = 0.0f;
    [SerializeField]
    private float moveSpeed = 0.0f;

    //���C�t�|�C���g
    public int Life = 0;

    Rigidbody rb = null;
    private bool IsJump = false;
    public bool IsSpawn = false;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();  // rigidbody���擾
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

    #region �ڐG����
    void OnCollisionEnter(Collision collision)
    {
        IsJump = true;

        //���C�t�����炷����
        if(gameObject.tag.Contains("PlayerDeath") == true)
        {
            Life--;
        }
    }
    #endregion

    #region �ړ��֘A
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsJump == true)
            {
                Vector3 force = new Vector3(0.0f, jumpPower, 0.0f);
                rb.AddForce(force);  // �͂�������
                IsJump = false;
            }
        }
    }

    public void Move()
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
    private void Resurrection()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            IsSpawn = true;
        }
    }
    #endregion

}

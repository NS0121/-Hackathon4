using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_PlayerScript : MonoBehaviour
{
    public int ResurrectCount = 0;
    [SerializeField] private float jumpPower = 0f;
    [SerializeField] private float moveSpeed = 0f;
    private bool IsJump = false;
    public bool IsSpawn = false;
    public static S_PlayerScript instance;


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
            if ( IsJump)
            {
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
        if (Input.GetKeyDown(KeyCode.E) && ResurrectCount > 0)
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
    }
    #endregion
}
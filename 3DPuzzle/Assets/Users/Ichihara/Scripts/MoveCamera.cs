using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Player�ɒǏ]����J������ݒ�
/// </summary>

public class MoveCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject _mainCamera = null;

    private Vector3 _thisObjPosition = default;
    private float zAdjust = 0.0f;

    private void Start()
    {
        zAdjust = -10.0f;
    }

    private void Update()
    {
        _thisObjPosition = this.transform.position;

        Debug.Log("�ʂ�����");
        PlayerStatus.instance.Move();

        //Player��x,y���W�ɒ���
        _mainCamera.transform.position =
            new Vector3(_thisObjPosition.x, _thisObjPosition.y, _thisObjPosition.z + zAdjust);            

    }
}

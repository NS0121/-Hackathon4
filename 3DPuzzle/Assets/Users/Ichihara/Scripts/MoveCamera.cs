using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Playerに追従するカメラを設定
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

        Debug.Log("通ったよ");
        PlayerStatus.instance.Move();

        //Playerのx,y座標に調整
        _mainCamera.transform.position =
            new Vector3(_thisObjPosition.x, _thisObjPosition.y, _thisObjPosition.z + zAdjust);            

    }
}

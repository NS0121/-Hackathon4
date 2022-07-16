using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Player‚É’Ç]‚·‚éƒJƒƒ‰‚ğİ’è
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

        Debug.Log("’Ê‚Á‚½‚æ");
        PlayerStatus.instance.Move();

        //Player‚Ìx,yÀ•W‚É’²®
        _mainCamera.transform.position =
            new Vector3(_thisObjPosition.x, _thisObjPosition.y, _thisObjPosition.z + zAdjust);            

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public static CheckPoint instance { get => _instance; }
    static CheckPoint _instance;

    public bool CheckPointFlag = false;

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            CheckPointFlag = true;
        }
    }

}

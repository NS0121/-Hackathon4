using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    public static EndPoint instance { get => _instance; }
    static EndPoint _instance;

    public bool EndPointFlag = false;

    private void Awake()
    {
        if(_instance = null)
        {
            _instance = this;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            EndPointFlag = true;
        }
    }
}

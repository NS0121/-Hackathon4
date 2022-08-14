using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crum_floor_Manger : MonoBehaviour
{
    [SerializeField] GameObject Crumbling_floor1;
    [SerializeField] GameObject Crumbling_floor2;
    [SerializeField] GameObject Crumbling_floor3;
    [SerializeField] GameObject Crumbling_floor4;
    [SerializeField] GameObject Crumbling_floor5;
    [SerializeField] GameObject Crumbling_floor6;
    [SerializeField] GameObject Crumbling_floor7;

    // Update is called once per frame
    void Update()
    {
        if (Test_PlayerScript.Spawn)   //スポーンがTrueだったら
        {
            //崩れる床を全部trueにする
            Crumbling_floor1.SetActive(true);
            Crumbling_floor2.SetActive(true);
            Crumbling_floor3.SetActive(true);
            Crumbling_floor4.SetActive(true);
            Crumbling_floor5.SetActive(true);
            Crumbling_floor6.SetActive(true);
            Crumbling_floor7.SetActive(true);

            Test_PlayerScript.Spawn = false;
        }
    }
}

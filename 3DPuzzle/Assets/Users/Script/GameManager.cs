using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject SpawnObj;
    public GameObject PlayerObj;
    public GameObject StartPoint;
    // Start is called before the first frame update

    void Start()
    {
        PlayerObj.transform.position = StartPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (S_PlayerScript.instance.IsSpawn)
        {
            Instantiate(SpawnObj, new Vector3(PlayerObj.transform.position.x,
                                              PlayerObj.transform.position.y,
                                              PlayerObj.transform.position.z), Quaternion.identity);
            PlayerObj.transform.position = StartPoint.transform.position;
            S_PlayerScript.instance.IsSpawn = false;
        }
    }
}

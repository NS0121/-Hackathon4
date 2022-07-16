using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Ichihara : MonoBehaviour
{
    public GameObject SpawnObj = null;
    public GameObject PlayerObj = null;
    public GameObject StartPoint = null;

    // Update is called once per frame
    void Start()
    {
        Instantiate(PlayerObj, StartPoint.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        SpawnObject();
    }

    private void SpawnObject()
    {
        if (PlayerStatus.instance.IsSpawn == true)
        {
            Instantiate(SpawnObj, new Vector3(PlayerObj.transform.position.x,
                                              PlayerObj.transform.position.y,
                                              PlayerObj.transform.position.z), Quaternion.identity);
            PlayerObj.transform.position = StartPoint.transform.position;
            PlayerStatus.instance.IsSpawn = false;
        }
    }

}

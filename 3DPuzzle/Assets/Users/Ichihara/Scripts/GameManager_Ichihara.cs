using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Ichihara : MonoBehaviour
{
    public GameObject SpawnObj = null;
    public GameObject PlayerObj = null;
    public GameObject StartPointZone = null;
    public GameObject CheckPointZone = null;

    // Update is called once per frame
    void Start()
    {
        PlayerObj.transform.position = StartPointZone.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnObject();

        if (Input.GetKey(KeyCode.Escape))
        {
            EndGame();
        }
    }

    private void SpawnObject()
    {
        if (PlayerStatus.instance.IsSpawn == true)
        {
            Instantiate(SpawnObj, new Vector3(PlayerObj.transform.position.x,
                                              PlayerObj.transform.position.y,
                                              PlayerObj.transform.position.z), Quaternion.identity);

            if (CheckPoint.instance.CheckPointFlag == false)
            {
                PlayerObj.transform.position = StartPointZone.transform.position;
            }
            else if (CheckPoint.instance.CheckPointFlag == true)
            {
                PlayerObj.transform.position = CheckPointZone.transform.position;
            }

            PlayerStatus.instance.IsSpawn = false;
        }
    }

    /// <summary>
    /// ゲーム終了処理
    /// </summary>
    private void EndGame()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;   // UnityEditorの実行を停止する処理
#else
        Application.Quit();                                // ゲームを終了する処理
#endif
        
    }
}

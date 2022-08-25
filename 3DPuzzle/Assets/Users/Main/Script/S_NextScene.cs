using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_NextScene : MonoBehaviour
{
    public static int stageNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Metoki")
        {
            stageNum++;
            SceneManager.LoadScene("game" + stageNum);
        }
    }
}

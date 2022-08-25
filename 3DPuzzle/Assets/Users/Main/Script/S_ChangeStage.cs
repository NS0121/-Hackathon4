using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_ChangeStage : MonoBehaviour
{
    int gamenum = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangegameScene()
    {
        SceneManager.LoadScene("game" + gamenum);
    }
}

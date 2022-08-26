using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextManager_Ichihara : MonoBehaviour
{
    //テキストコンポーネント
    [SerializeField]
    private TextMeshProUGUI remainingLives;
    [SerializeField]
    private TextMeshProUGUI resurrectCount;

    // Start is called before the first frame update
    void Start()
    {
        remainingLives.text = "Life" + PlayerStatus.instance.Life.ToString();
        resurrectCount.text = "Resurrect";
    }

    // Update is called once per frame
    void Update()
    {

    }
}

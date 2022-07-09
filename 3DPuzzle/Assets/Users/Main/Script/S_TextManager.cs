using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S_TextManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI resurrectCount;
    private int TextResurrect = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        TextResurrect = S_PlayerScript.instance.ResurrectCount;
        resurrectCount.text = "Resurrect" + TextResurrect;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField]
    private GameObject _startPoint = null;

    [SerializeField]
    private GameObject _checkPoiint = null;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player") == true)
        {
            StartCoroutine(ReburnPlayer(other.gameObject));
        }
    }

    IEnumerator ReburnPlayer(GameObject obj)
    {
        obj.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        obj.SetActive(true);

        if(CheckPoint.instance.CheckPointFlag == false)
        {
            obj.gameObject.transform.position = _startPoint.transform.position;
        }
        else if(CheckPoint.instance.CheckPointFlag == true)
        {
            obj.gameObject.transform.position = _checkPoiint.transform.position;
        }
    }
}

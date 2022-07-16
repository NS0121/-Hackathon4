using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField]
    private GameObject _startPoint = null;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") == true)
        {
            StartCoroutine(ReburnPlayer(collision.gameObject));
        }
    }

    IEnumerator ReburnPlayer(GameObject obj)
    {
        obj.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        obj.SetActive(true);
        obj.gameObject.transform.position = _startPoint.transform.position;
    }
}

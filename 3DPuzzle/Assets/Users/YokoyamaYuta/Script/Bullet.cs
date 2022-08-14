using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(0, 4f * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider other) //’Ç‰Á
    {
        if (other.gameObject.tag == "Player" || other.gameObject.name == "Ground")
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    [SerializeField] GameObject Bullet;@       //’e
    [SerializeField] Transform BulletPoint;     //’e‚Ì”­¶êŠ

    private int count;

    void Update()
    {
        count += 1;
        
        // 540ƒtƒŒ[ƒ€‚²‚Æ‚É–C’e‚ğ”­Ë‚·‚é
        if (count % 540 == 0)
        {
            Instantiate(Bullet, BulletPoint.position, BulletPoint.rotation);
        }
    }
}

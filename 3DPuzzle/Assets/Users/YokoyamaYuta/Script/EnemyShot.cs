using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    [SerializeField] GameObject Bullet;　       //弾
    [SerializeField] Transform BulletPoint;     //弾の発生場所

    private int count;

    void Update()
    {
        count += 1;
        
        // 540フレームごとに砲弾を発射する
        if (count % 540 == 0)
        {
            Instantiate(Bullet, BulletPoint.position, BulletPoint.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    [SerializeField] GameObject Bullet;�@       //�e
    [SerializeField] Transform BulletPoint;     //�e�̔����ꏊ

    private int count;

    void Update()
    {
        count += 1;
        
        // 540�t���[�����ƂɖC�e�𔭎˂���
        if (count % 540 == 0)
        {
            Instantiate(Bullet, BulletPoint.position, BulletPoint.rotation);
        }
    }
}

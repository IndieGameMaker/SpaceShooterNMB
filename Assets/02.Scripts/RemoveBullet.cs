using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    public GameObject sparkEffect;

    // 충돌 콜백함수(이벤트)
    void OnCollisionEnter(Collision coll)
    {
        // 충돌한 물체가 총알인지 여부를 판단
        // if (coll.collider.tag == "BULLET")  // Garbage Collection (Managed Laugauge : C#, Java)
        // {
        //     //총알을 삭제
        //     Destroy(coll.gameObject);
        // }

        if (coll.collider.CompareTag("BULLET"))
        {
            //총알을 삭제
            Destroy(coll.gameObject);

            // 충돌 지점(좌표) 추출
            Vector3 pos = coll.GetContact(0).point;
            // 법선 벡터(Normal Vector)
            Vector3 _normal = -coll.GetContact(0).normal;
            // 법선 벡터의 각도를 쿼터니언 타입으로 변환
            Quaternion rot = Quaternion.LookRotation(_normal);

            // 스파크 이펙트를 생성
            GameObject spark = Instantiate(sparkEffect, pos, rot);
            Destroy(spark, 0.5f);
        }
    }
}

/*
    쿼터니언 (Quaternion) : 사원수  (x, y, z, w) : 복소수 사차원 벡터

    오일러 회전(Euler) 0~360 
    x -> y -> z

    * Gimbal Lock (짐벌락, 김벌락)



*/













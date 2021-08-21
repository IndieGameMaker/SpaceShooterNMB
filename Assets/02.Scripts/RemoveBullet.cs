using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    // 충돌 콜백함수(이벤트)
    void OnCollisionEnter(Collision coll)
    {
        // 충돌한 물체가 총알인지 여부를 판단
        if (coll.collider.tag == "BULLET")
        {
            //총알을 삭제
            Destroy(coll.gameObject);
        }
    }
}

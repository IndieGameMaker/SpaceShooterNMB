using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public Transform tr;

    private float h, v, r;
    [System.NonSerialized]
    public float moveSpeed = 6.0f;
    [HideInInspector]
    public float turnSpeed = 100.0f;

    void Start()
    {
        tr = GetComponent<Transform>();  // tr = this.gameObject.GetComponent<Transform>();
    }

    // 렌더링 주기 30FPS = 1/30 sec
    void Update()
    {
        v = Input.GetAxis("Vertical");  // -1.0f ~ 0.0f ~ +1.0f
        h = Input.GetAxis("Horizontal");// -1.0f ~ 0.0f ~ +1.0f
        r = Input.GetAxis("Mouse X");

        // 이동처리
        Vector3 dir = (Vector3.forward * v) + (Vector3.right * h);
        tr.Translate(dir.normalized * Time.deltaTime * moveSpeed);
        // 회전처리
        tr.Rotate(Vector3.up * Time.deltaTime * turnSpeed * r);
    }

    /*
        정규화 벡터 (Normalized Vector), 단위벡터(Unit Vector)

        Vector3.forward = Vector3(0, 0, 1)
        Vector3.up      = Vector3(0, 1, 0)
        Vector3.right   = Vector3(1, 0, 0)

        Vector3.zero    = Vector3(0, 0, 0)
        Vector3.one     = Vector3(1, 1, 1)
    */
}

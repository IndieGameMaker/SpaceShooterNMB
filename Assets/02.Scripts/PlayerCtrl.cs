using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public Transform tr;

    private float h, v;

    void Start()
    {
        tr = GetComponent<Transform>();  // tr = this.gameObject.GetComponent<Transform>();
    }

    // 렌더링 주기 30FPS = 1/30 sec
    void Update()
    {
        //tr.position += new Vector3(0, 0, 0.1f);
        tr.position += Vector3.forward * 0.1f;
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

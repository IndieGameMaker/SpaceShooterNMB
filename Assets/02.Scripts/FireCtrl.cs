using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Instantiate (생성할 객체, 위치, 회전);
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
    }
}

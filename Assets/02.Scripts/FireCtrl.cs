using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePos;
    public AudioClip fireSfx;

    private new AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        //Instantiate (생성할 객체, 위치, 회전);
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        // 총소리를 발생(재생)
        audio.PlayOneShot(fireSfx, 0.8f);
    }
}




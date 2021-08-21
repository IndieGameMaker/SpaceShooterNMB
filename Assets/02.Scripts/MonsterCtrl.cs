using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCtrl : MonoBehaviour
{
    private Transform playerTr;

    void Start()
    {
        //GameObject playerObject = GameObject.Find("Player");
        GameObject playerObject = GameObject.FindGameObjectWithTag("PLAYER");
        playerTr = playerObject.GetComponent<Transform>();

        //playerTr = GameObject.FindGameObjectWithTag("PLAYER")?.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

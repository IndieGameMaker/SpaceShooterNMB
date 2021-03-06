using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;  // NavMeshAgent 컴포넌트

public class MonsterCtrl : MonoBehaviour
{
    private Transform playerTr;
    private NavMeshAgent agent;
    private Animator anim;

    void Start()
    {
        //GameObject playerObject = GameObject.Find("Player");
        GameObject playerObject = GameObject.FindGameObjectWithTag("PLAYER");
        playerTr = playerObject.GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

        //playerTr = GameObject.FindGameObjectWithTag("PLAYER")?.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(playerTr.position);
        anim.SetBool("IsTrace", true);
    }
}

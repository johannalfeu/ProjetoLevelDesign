using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(CapsuleCollider))]
public class Inimigo : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent navMesh;
    private bool podeAtacar;
    
    void Start()
    {
        podeAtacar = true;
        player = GameObject.FindWithTag("Player");
        navMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = player.transform.position;
        navMesh.destination = position;
        if (Vector3.Distance(transform.position, player.transform.position) < 0.5) 
        {
            Atacar();
        }

    }

    void Atacar() 
    {
        if (podeAtacar == true) 
        {
            StartCoroutine("TempoDeAtaque");
            player.GetComponent<PlayerVida>().VidaPersonagem -= 20;
            
        }
    }
    IEnumerator TempoDeAtaque()
    {
        podeAtacar = false;
        yield return new WaitForSeconds(1);
        podeAtacar = true;
    }

   
}

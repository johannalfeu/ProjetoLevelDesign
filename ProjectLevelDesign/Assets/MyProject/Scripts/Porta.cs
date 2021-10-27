using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    public Animator anim;

    private bool colisao;
    private bool PortaAberta = false;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && colisao)
        {
            PortaAberta = true;
            anim.SetTrigger("Abrir");
        }
    }

     void OnTriggerEnter(Collider col) {
        if(col.gameObject.CompareTag("Player"))
        {
            colisao = true;
        }
    }

     void OnTriggerExit(Collider col) {
        if(col.gameObject.CompareTag("Player"))
        {
            if(PortaAberta)
            {
                anim.SetTrigger("Fechar");
            }

            colisao = false;
        }
    }
}

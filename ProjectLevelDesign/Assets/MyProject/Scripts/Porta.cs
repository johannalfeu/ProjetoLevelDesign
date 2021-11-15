using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    public GameObject key;
    public bool ContemChave;

    public Animator anim;

    private bool colisao;
    private bool PortaAberta = false;
    void Start()
    {
        ContemChave = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && colisao && ContemChave == true)
        {
            PortaAberta = true;
            anim.SetTrigger("Abrir");
        }

        ContemChave = key.GetComponent<Chave>().temChave;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            colisao = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            if (PortaAberta)
            {
                anim.SetTrigger("Fechar");
            }

            colisao = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Porta : MonoBehaviour
{
    public GameObject key;
    public bool ContemChave;

    public Animator anim;

    private bool colisao;
    private bool PortaAberta = false;

    AudioSource audioData;
    public AudioClip clip;
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        ContemChave = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && colisao && ContemChave == true)
        {
            PortaAberta = true;
            audioData.PlayOneShot(clip, 0.7f);
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

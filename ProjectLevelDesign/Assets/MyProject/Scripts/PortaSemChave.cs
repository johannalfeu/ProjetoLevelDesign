using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PortaSemChave : MonoBehaviour
{
    public Animator anim;

    private bool colisao;
    private bool PortaAberta = false;

    AudioSource audioData;
    public AudioClip clip;
    void Start()
    {

        audioData = GetComponent<AudioSource>();
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && colisao)
        {
            PortaAberta = true;
            audioData.PlayOneShot(clip, 0.7f);
            anim.SetTrigger("Abrir");
        }

        
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

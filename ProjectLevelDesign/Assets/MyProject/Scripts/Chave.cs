using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Chave : MonoBehaviour
{
    public float distanciaDaChave = 3;
    public bool temChave;
    private GameObject player;
    public GameObject obj;
    AudioSource audioData;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        temChave = false;
        player = GameObject.FindWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < distanciaDaChave)
        {
            if (Input.GetKeyDown(KeyCode.E) && temChave == false)
            {
                temChave = true;
                audioData.PlayOneShot(clip, 0.3f);
                transform.position = obj.transform.position;
            }
        }


    }


}

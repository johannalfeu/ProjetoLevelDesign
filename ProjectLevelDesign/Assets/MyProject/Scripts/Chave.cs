using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chave : MonoBehaviour
{
    public float distanciaDaChave = 3;
    public bool temChave;
    private GameObject player;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
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
                transform.position = obj.transform.position;
            }
        }


    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerVida : MonoBehaviour
{
    public float VidaPersonagem;
    public Texture BarraVida, Contorno;
    public int vida = 100;

    void Start()
    {
        VidaPersonagem = vida;
    }

    // Update is called once per frame
    void Update()
    {
        if(VidaPersonagem >= vida)
        {
            VidaPersonagem = vida;           
        }else if (VidaPersonagem <= 0)
        {
            VidaPersonagem = 0;
            Invoke("Morte", 0.5f);
        }
    }

     void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width / 25, Screen.height / 15, Screen.width / 5.5f / vida * VidaPersonagem, Screen.height / 25), BarraVida);
        GUI.DrawTexture(new Rect(Screen.width / 40, Screen.height / 40, Screen.width / 5, Screen.height / 8), Contorno);
    }

    void Morte()
    {
        SceneManager.LoadScene("Scene2");
    }
    
}

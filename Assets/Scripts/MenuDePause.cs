using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDePause : MonoBehaviour
{
    public void ResumirJogo()
    {
         Debug.Log("Botão clicado!");
         GameManager.instance.DespausarJogo();
       
    }

    public void SairDoJogo()
    {
        Debug.Log("Saiu do Jogo");
        Application.Quit();
        Debug.Log("Saiu do Jogo");
    }
}

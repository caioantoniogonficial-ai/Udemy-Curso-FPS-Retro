using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassardeFase : MonoBehaviour
{
    public string faseParaCarregar;

   void OnTriggerEnter2D(Collider2D other)
   {
        if(other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(faseParaCarregar);
        }
   }
}

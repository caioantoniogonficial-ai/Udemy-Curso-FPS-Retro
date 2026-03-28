using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public string nomeDaFase;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void IniciarJogo()
    {
        SceneManager.LoadScene(nomeDaFase);
    }

    public void SairdoJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo");
    }
}

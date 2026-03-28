using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OsEfeitosSonoros : MonoBehaviour
{
    public static OsEfeitosSonoros instance;

    public AudioSource somDoAtaqueDoInimigo;
    public AudioSource somDoAtaqueDoJogador, somDaChave, somDanoDoInimigo, somDanoDoJogador, somInimigoDerrotado, somMunicao, somSemMunicao, somDaVida;

    void Awake()
    {
        instance = this;
    }

    public void TocarAtaqueDoInimigo()
    {
        somDoAtaqueDoInimigo.Play();
    }

    public void TocarAtaqueDoJogador() {somDoAtaqueDoJogador.Play();}

    public void TocarChave() {somDaChave.Play();}

    public void TocarDanoDoInimigo() {somDanoDoInimigo.Play();}

    public void TocarDanoDoJogador() {somDanoDoJogador.Play();}

    public void TocarInimigoDerrotado() {somInimigoDerrotado.Play();}

    public void TocarSomDaMunicao() {somMunicao.Play();}

    public void TocarSomSemMunicao() {somSemMunicao.Play();}

    public void TocarSomDaVida() {somDaVida.Play();}

}

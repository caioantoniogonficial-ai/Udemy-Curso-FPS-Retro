using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AtaqueDoJogador : MonoBehaviour
{
    public Camera cameraDoJogo;
    public GameObject efeitoDeImpacto;
    public Animator animatorDaArma;
    public TMP_Text textodaMunicao;

    public int municaoMaxima;
    public int municaoAtual;
    public int danoParaDar;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        textodaMunicao.text = "MUNIÇÃO\n" + municaoAtual;
    }

    // Update is called once per frame
    void Update()
    {   if(GameManager.instance.jogoPausado == false && GameManager.instance.jogadorEstaVivo == true)
        {
            Atirar();
        }
    }

    private void Atirar()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(municaoAtual > 0)
            {
                Ray raio = cameraDoJogo.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
                RaycastHit localAtingido;

                if(Physics.Raycast(raio, out localAtingido))
                {
                    Instantiate(efeitoDeImpacto, localAtingido.point, localAtingido.transform.rotation);
                    Debug.Log("Estou olhando para: " + localAtingido.transform.name);

                    if(localAtingido.transform.gameObject.CompareTag("Inimigo"))
                    {
                        localAtingido.transform.gameObject.GetComponentInParent<Inimigo>().MachucarInimigo(danoParaDar);
                    }
                }
                else
                {
                    Debug.Log("Não estou olhando nada");
                }

                municaoAtual -=1;
                OsEfeitosSonoros.instance.TocarAtaqueDoJogador();
                textodaMunicao.text = "MUNIÇÃO\n" + municaoAtual;            
                animatorDaArma.SetTrigger("Arma Atirando");
            }
            else
            {
                OsEfeitosSonoros.instance.TocarSomSemMunicao();
                Debug.Log("Sem Munição");
            }
        }
    }

    public void GanharMunicao(int municaoParaReceber)
    {
        if(municaoAtual + municaoParaReceber < municaoMaxima)
        {
            municaoAtual = municaoAtual + municaoParaReceber;
        }
        else
        {
            municaoAtual = municaoMaxima;
        }

        textodaMunicao.text = "MUNIÇÃO\n" + municaoAtual;

    }

}  

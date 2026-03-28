using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoJogador : MonoBehaviour
{
    public static ControleDoJogador instance;

    public Rigidbody2D oRigidbody2D;
    public Animator animatorDoPainelDaArma;

    public float velocidadeDoJogador;
    public float sensibilidadeDoMouse;

    private Vector2 comandosDoTeclado;
    private Vector2 movimentoDoMouse;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.jogoPausado == false && GameManager.instance.jogadorEstaVivo == true)
        {
            MovimentarJogador();
            GirarCamera();
        }
    }

    private void MovimentarJogador()
    {
        comandosDoTeclado = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        Vector3 movimentoHorizontal = transform.up * -comandosDoTeclado.x;
        Vector3 movimentoVertical = transform.right * comandosDoTeclado.y;

        oRigidbody2D.velocity = (movimentoHorizontal + movimentoVertical) * velocidadeDoJogador;
        oRigidbody2D.velocity.Normalize();

        if(oRigidbody2D.velocity.magnitude == 0)
        {
            animatorDoPainelDaArma.Play("Jogador Parado");
        }
        else
        {
            animatorDoPainelDaArma.Play("Jogador Andando");
        }
    }

    private void GirarCamera()
    {
         movimentoDoMouse = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y") * sensibilidadeDoMouse);

         transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z - movimentoDoMouse.x);
    }
}

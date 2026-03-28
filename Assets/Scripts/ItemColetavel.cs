using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemColetavel : MonoBehaviour
{
    public bool itemDeMunicao;
    public bool itemDeVida;
    public bool chavePrateada;
    public bool chaveDourada;

    public int municaoParaDar;
    public int vidaParaDar;

   void OnTriggerEnter2D(Collider2D other)
   {
       if(other.gameObject.CompareTag("Player"))
       {
           if(itemDeMunicao == true)
           {
                other.gameObject.GetComponent<AtaqueDoJogador>().GanharMunicao(municaoParaDar);
                OsEfeitosSonoros.instance.TocarSomDaMunicao();
           }

           if(itemDeVida == true)
           {
                other.gameObject.GetComponent<VidaDoJogador>().GanharVida(vidaParaDar);
                OsEfeitosSonoros.instance.TocarSomDaVida();
           }

           if(chavePrateada == true)
           {
                GameManager.instance.temChavePrateada = true;
                OsEfeitosSonoros.instance.TocarChave();
           }

           if(chaveDourada == true)
           {
                GameManager.instance.temChaveDourada = true;
                OsEfeitosSonoros.instance.TocarChave();
           }

           Destroy(this.gameObject);
       }
   }
}

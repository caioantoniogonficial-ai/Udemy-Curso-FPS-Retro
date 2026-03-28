using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OlharParaJogador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(ControleDoJogador.instance.transform.position, -Vector3.forward);
    }
}

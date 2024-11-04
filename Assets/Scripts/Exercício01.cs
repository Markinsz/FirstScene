using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    /*
 
        1. (Verificação de pontos de vida) Um personagem perde pontos
        de vida após uma batalha. Verifique se ele ainda está vivo. Caso
        tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso
        contrário, "Game Over".

    */

public class Exercício01 : MonoBehaviour

{
    [SerializeField] int vidaPersonagem;

    // Start is called before the first frame update
    void Start()
    {
        if (vidaPersonagem > 0)
        {
            print("Personagem Vivo");
        }
        else
        {
            print("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

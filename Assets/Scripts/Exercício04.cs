using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
    4. Um jogador possui itens limitados
    no inventário. Verifique se o jogador possui uma "Poção de Vida".
    Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
    indisponível".

*/

public class Exercício04 : MonoBehaviour
{
    [SerializeField] bool PocaoDeVida;


    // Start is called before the first frame update
    void Start()
    {
        if (PocaoDeVida == true)
        {
            print("Usando poção de vida");
        }
        else
        {
            print("Poção indisponível");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

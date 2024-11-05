using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
6. O jogador pode escolher entre o
personagem Guerreiro ou Mago. Exiba "Guerreiro escolhido" se o
jogador selecionar Guerreiro e "Mago escolhido" se selecionar
Mago.
 
 */

public class Exercício06 : MonoBehaviour
{

    [SerializeField] string Classe;

    // Start is called before the first frame update
    void Start()
    {
        switch (Classe)
        {
            case "Mago":
                print("Mago escolhido");
                break;
            case "Guerreiro":
                print("Guerreiro escolhido");
                break;
            default:
                print("Classe não reconhecida");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

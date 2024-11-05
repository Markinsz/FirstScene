using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
 10. Crie um script onde o jogador pode coletar
diferentes tipos de itens (como moedas, poções, ou power-ups)
que têm efeitos diferentes dependendo do tipo coletado. Use um
switch case para determinar o efeito de cada tipo de item.
 
 */

public class Exertcício10 : MonoBehaviour
{

    [SerializeField] string Itens;

    // Start is called before the first frame update
    void Start()
    {

        

        switch (Itens) { 
            case "moeda":
                print("Tio Patinhas tá preocurando isso!");
                break;
            case "poção de vida":
                print("Full Health!");
                break;
            case "poção de mana":
                print("Mana regen 100!");
                break;
            case "velocidade":
                print("Rápido como um flash!");
                break;
            case "proteção":
                print("Duro como pedra!");
                break;
            case "flor de fogo":
                print("Olha o copyright...");
                break;
            default:
                Debug.Log("Escolha entre moeda, poção de vida, poção de mana, velocidade, proteção ou flor de fogo");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

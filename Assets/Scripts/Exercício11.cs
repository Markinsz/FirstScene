using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 
    11. Implemente um sistema de diálogos onde o jogador
    pode interagir com um NPC (personagem não jogável), e o NPC
    responde com diferentes frases dependendo do estado do jogo.
    Use switch case para definir as respostas baseadas no estado do
    jogador.
 
 */


public class Exercício11 : MonoBehaviour
{

    //[SerializeField]int vidaPlayer;

    // Start is called before the first frame update
    void Start()
    {

        //    FindObjectOfType<Exercício03>().vidaPersonagem = 10;

        //    switch (vidaPlayer)
        //    {
        //        case <= 25:
        //            print("Goblin 1: Você está nas piores hein?");
        //            print("Goblin 2: Qualquer outro estaia morto no seu estado");
        //            break;
        //        case <= 50:
        //            print("Goblin 1: Você está bem machucado...");
        //            print("Goblin 2: Vá ao médico se tratar");
        //            break;
        //        case <= 75:
        //            print("Goblin 1: Alguns arranhões podem ser fatais...");
        //            print("Goblin 2: Isso não afetará nosso herói");
        //            break;
        //        case <= 100:
        //            print("Goblin 1: Então... nem um machucado...");
        //            print("Goblin 2: Não esperava menos do nosso herói");
        //            break;

        //    }

        //    switch (vidaPersonagem)
        //    {
        //        case <= 25:
        //            print("Goblin 1: Você está nas piores hein?");
        //            print("Goblin 2: Qualquer outro estaia morto no seu estado");
        //            break;
        //        case <= 50:
        //            print("Goblin 1: Você está bem machucado...");
        //            print("Goblin 2: Vá ao médico se tratar");
        //            break;
        //        case <= 75:
        //            print("Goblin 1: Alguns arranhões podem ser fatais...");
        //            print("Goblin 2: Isso não afetará nosso herói");
        //            break;
        //        case <= 100:
        //            print("Goblin 1: Então... nem um machucado...");
        //            print("Goblin 2: Não esperava menos do nosso herói");
        //            break;

        //    }

        Exercício03 exercicio03 = FindObjectOfType<Exercício03>();

        if (exercicio03 != null)
        {
            // Executa o switch com base no valor de vidaPersonagem
            ExibirMensagem(exercicio03.vidaPersonagem);
        }
        else
        {
            Debug.LogWarning("Exercício03 não encontrado na cena.");
        }
    }

    void ExibirMensagem(int vida)
    {
        // Usa switch para verificar o valor de vida e imprimir as mensagens
        switch (vida)
        {
            case <= 25:
                print("Goblin 1: Você está nas piores hein?");
                print("Goblin 2: Qualquer outro estaria morto no seu estado");
                break;
            case <= 50:
                print("Goblin 1: Você está bem machucado...");
                print("Goblin 2: Vá ao médico se tratar");
                break;
            case <= 75:
                print("Goblin 1: Alguns arranhões podem ser fatais...");
                print("Goblin 2: Isso não afetará nosso herói");
                break;
            case <= 100:
                print("Goblin 1: Então... nem um machucado...");
                print("Goblin 2: Não esperava menos do nosso herói");
                break;
            default:
                print("Vida fora do intervalo esperado.");
                break;
        }
    }

}



// Update is called once per frame
//void Update()
//{

//}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
    3. Considere que o jogo tem um power-up que revive o
    personagem caso ele morra. Caso o jogador morra e tiver
    coletado o power-up ele volta a vida com 50% de sua vida total e
    deve ser exibido a mensagem "Ainda não, vida atual XX". Caso ele
    não tenha coletado o power-up exiba "Game Over".
 
 */

public class Exercício03 : MonoBehaviour
{
    [SerializeField] bool powerupColetado;
    public int vidaPersonagem = 100;

    // Start is called before the first frame update
    void Start()
    {
        if (powerupColetado == true && vidaPersonagem == 0)
        {
            vidaPersonagem = 50;
            print("Ainda não, vida atual" + vidaPersonagem);
        }
        else if (vidaPersonagem > 0)
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 
    9. Crie um script que lê o placar de uma partida entre
time A e time B. Depois, escreva no console qual dos três
resultados possíveis aconteceu: vitória do time A, vitória do time B
ou empate. Se o empate teve mais de 3 pontos para cada lado,
escreva que foi “um empate emocionante”.
 
 */


public class Exercício09 : MonoBehaviour
{

    [SerializeField] int PontuacaoTimeA;
    [SerializeField] int PontuacaoTimeB;
    //int Resultado;

    // Start is called before the first frame update
    void Start()
    {
        //Resultado = PontuacaoTimeA - PontuacaoTimeB;

        //switch(Resultado)
        //{
        //    case > 0:
        //        print("Vitória do Time A");
        //        break;
        //    case < 0:
        //        print("Vitória do Time B");
        //        break;
        //    case 0:
        //        print("Empate");
        //        break;
        //}

        if (PontuacaoTimeA > PontuacaoTimeB)
        {
            print("Vitória do time A");
        }
        else if (PontuacaoTimeA < PontuacaoTimeB)
        {
            print("Vitória do time B");
        }
       
        if (PontuacaoTimeA == PontuacaoTimeB && PontuacaoTimeA >= 3 && PontuacaoTimeB >= 3)
        {
            print("Empate emocionante!");
        }
        else if (PontuacaoTimeA == PontuacaoTimeB)
        {
            print("Empate");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

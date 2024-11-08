using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
 1.(Contagem regressiva de tempo) Crie uma contagem
regressiva de 5 a 1 e exiba "Início da partida!" ao final.
 
 */

public class Exercício1 : MonoBehaviour
{
        int Contagem = 5;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            print(Contagem);
            Contagem--;

            if (i == 4)
            {
                print("Início da Partida!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

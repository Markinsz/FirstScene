using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
2. (Multiplicação de dano) Um personagem ataca cinco vezes, e o
dano do ataque aumenta em 2 a cada vez. Exiba o dano a cada
ataque.
 
 */

public class Exercício2 : MonoBehaviour
{
    int Dano = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 5; i++)
        {
            Dano = Dano + 2;
            print(Dano);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

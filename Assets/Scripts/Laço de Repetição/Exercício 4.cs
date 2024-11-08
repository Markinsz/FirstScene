using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
4.(Pontuação em combos) Cada combo realizado aumenta em 10
pontos. Exiba a pontuação total após 7 combos.
 
 */

public class Exercício4 : MonoBehaviour
{
    [SerializeField] int Pontuação = 0;
    [SerializeField] int NumCombo = 7;
    int contador;

    // Start is called before the first frame update
    void Start()
    {
        while (contador < NumCombo)
        {
            contador++;
            Pontuação += 10;
        }

        print(Pontuação);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/*
 
7. (Maior número em uma lista) Dada uma lista de números,
encontre o maior valor.
 
 */

public class Exercício7 : MonoBehaviour
{

    [SerializeField] int[] números;

    // Start is called before the first frame update
    void Start()
    {
        int maior = números[0];

        foreach (int n in números)
        {
            if (n > maior)
            {
                maior = n;
            }

        }
            print("O maior número é: " + maior);

    }


    // Update is called once per frame
    void Update()
    {

    }

}

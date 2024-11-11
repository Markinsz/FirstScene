using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
6. (Fizz Buzz) Para cada número entre 0 e 10000, escreva apenas
“fizz” no console quando for divisível por 3, “buzz” quando for
divisível por 5 e “fizz buzz” quando for divisível pelos dois. Se o
número não for divisível por nenhum deles, escreva-o no console.
 
 */

public class Exercício6 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        for (float i = 0; i < 10000; i++) 
        { 
            if (i % 5 == 0 && i % 3 == 0)
            {
                print("Fizz Buzz");
            }
            else if (i % 3 == 0)
            {
                print("Fizz");
            }
            else if(i % 5 == 0)
            {
                print("Buzz");
            }
            else
            {
                print("Número não divisivel");
            }
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
    Escreva um programa que conta o número de consoantes em uma string.
 
 */

public class Desafio1 : MonoBehaviour
{

    [SerializeField] string palavra;
    char letra;
    int contador;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < palavra.Length; i++)
        {
            if ("qrtypsdfghjklzxcvbnm".Contains(char.ToLower(letra)))
            {
                contador++;
            }
        }

            //Errado
            //for (int i = 0; i < palavra.Length; i++)
            //{
            //    letra += palavra[i];
            //    if (letra != "a" & letra != "e" & letra != "i" & letra != "o" & letra != "u")
            //    {
            //        contador++;
            //        letra = "";
            //    }
            //    else 
            //    { 
            //        letra = ""; 
            //    }
            //}
            print(contador);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

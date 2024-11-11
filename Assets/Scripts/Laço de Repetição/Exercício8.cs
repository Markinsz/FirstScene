using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.UI.Image;

/*
 
8. (Reverter uma string) Escreva um programa que inverte uma
string usando um loop for.
 
 */

public class Exercício8 : MonoBehaviour
{
    [SerializeField] string palavra;
    string arvalap;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            arvalap += palavra[i];
        }
        print(arvalap);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

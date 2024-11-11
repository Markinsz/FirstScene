using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

/*
 
    Fa�a um algoritmo que receba o dia, o m�s e o ano em que uma pessoa nasceu, imprima na tela quantos anos, meses e dias essa pessoa j� viveu. 
    Leve em considera��o o ano com 365 dias e o m�s com 30 dias
 
 */

public class Desafio2 : MonoBehaviour
{

    [SerializeField] int dia;
    [SerializeField] int m�s;
    [SerializeField] int ano;

    // Start is called before the first frame update
    void Start()
    {
        
            // Cria a data de nascimento no formato correto (ano, m�s, dia)
            DateTime dataNascimento = new DateTime(ano, m�s, dia);
            DateTime dataAtual = DateTime.Now;

            int anos = 0;
            int meses = 0;
            int dias = 0;

            // Contabiliza os anos completos
            while (dataNascimento.AddYears(anos + 1) <= dataAtual)
            {
                anos++;
            }

            // Contabiliza os meses completos
            while (dataNascimento.AddYears(anos).AddMonths(meses + 1) <= dataAtual)
            {
                meses++;
            }

            // Contabiliza os dias completos
            while (dataNascimento.AddYears(anos).AddMonths(meses).AddDays(dias + 1) <= dataAtual)
            {
                dias++;
            }

            // Exibe o resultado na tela da Unity
            Debug.Log("A pessoa j� viveu: " + anos + " anos, " + meses + " meses e " + dias + " dias.");        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

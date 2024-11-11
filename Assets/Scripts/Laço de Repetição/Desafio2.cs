using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

/*
 
    Faça um algoritmo que receba o dia, o mês e o ano em que uma pessoa nasceu, imprima na tela quantos anos, meses e dias essa pessoa já viveu. 
    Leve em consideração o ano com 365 dias e o mês com 30 dias
 
 */

public class Desafio2 : MonoBehaviour
{

    [SerializeField] int dia;
    [SerializeField] int mês;
    [SerializeField] int ano;

    // Start is called before the first frame update
    void Start()
    {
        
            // Cria a data de nascimento no formato correto (ano, mês, dia)
            DateTime dataNascimento = new DateTime(ano, mês, dia);
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
            Debug.Log("A pessoa já viveu: " + anos + " anos, " + meses + " meses e " + dias + " dias.");        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

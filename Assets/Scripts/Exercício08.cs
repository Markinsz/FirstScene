using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
    8.Crie um script que em que uma
variável inteira hora seja incrementada de uma unidade a cada 10
segundos e volte a ser 0 quando alcançar o valor 24. Quando
completar um ciclo, incremente uma variável dias e escreva o
número de dias que se passaram no console. (Coloque o código
dentro da função-evento Update).
 
 */

public class Exercício08 : MonoBehaviour
{
    [SerializeField]int horas = 0;
    [SerializeField]int dia;
    [SerializeField] float intervalo;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Executando a cada " + intervalo + " segundos");
    }

    // Update is called once per frame
    void Update()
    {
        intervalo += Time.deltaTime;
        if (intervalo >= 10f)
        {
            // Executa o código que você quer no intervalo
            horas++;

            if (horas == 24)
            {
                horas = 0;
                dia++;
                print(dia + "dia(s) se passaram");
            }
            intervalo = 0f;
        }
       
    }
}

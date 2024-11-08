using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geral : MonoBehaviour
{

    //Tipos de Variáveis

    //float velocidadeCarro = 125.5F;

    //double velocidade = 125.5;

    //string nomeJogador = "MarkinsDaBala";

    //char apelido = 'M';

    //bool vivo = true;

    //int idade = 24;

    //int variavelGlobal;


    //Variável pública - É possível levar para outros scripts e aparece no inspector da Unity

    //public string variavelPublica;

    //Variável Privada - Exclusiva desse script

    //private string variavelPrivada;

    //[SerializeField] private int vidaJogador = 10; //SerializeField faz a variável aparecer no inspector da Unity

    /* 
            Operadores relacionais
                
                == (igual)
                =! (diferente)
                > (maior que)
                >= (maior igual)
                < (menor que)
                <= (menor igual)
     */

    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int vidaVilao = 300;
    string resultado;
    [SerializeField] int estadoVilao;


    // Start is called before the first frame update
    void Start()
    {
        //int variavelLocal = 10;
        //print(variavelLocal);

        //print(variavelGlobal);

        //Debug.Log(vidaJogador); //Debug.Log = print

        //print(vidaJogador);

        print(vidaVilao == vidaHeroi); //false
        print(vidaHeroi <= vidaVilao); //true
        print(vidaVilao != vidaHeroi); //true

        /* 
                Operador Ternário
                    condição ? valor a ser atribuido caso verdadeiro : caso falso
         
         */

        resultado = vidaVilao < vidaHeroi ? "Vida Herói Menor" : "Vida Herói Maior";

        print(resultado);

        /*
            Estrutura Condicional

        if (vidaHeroi < vidaVilao)
        {
            print("Vida Herói Menor");
            print("Get Better");
        }
        else if(vidaHeroi == vidaVilao)
        {
            print("Nosso duelo será LENDÁRIO!!!");
        }
        else
        {
            print("Vida Herói Maior");
            print("I'm better");
        }
        */

        /*
          
            Switch Case
         
            Switch(expression)
        {
                case x:
                    break;
                case y:
                    break;
                case z:
                    break;
                default:
                    break;
        }

         */

        }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello World!");

        //print(variavelGlobal);
        //print(variavelLocal); Da erro, pois a variávelLocal não existe no contexto local
    }
}
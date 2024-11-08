using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geral : MonoBehaviour
{

    //Tipos de Vari�veis

    //float velocidadeCarro = 125.5F;

    //double velocidade = 125.5;

    //string nomeJogador = "MarkinsDaBala";

    //char apelido = 'M';

    //bool vivo = true;

    //int idade = 24;

    //int variavelGlobal;


    //Vari�vel p�blica - � poss�vel levar para outros scripts e aparece no inspector da Unity

    //public string variavelPublica;

    //Vari�vel Privada - Exclusiva desse script

    //private string variavelPrivada;

    //[SerializeField] private int vidaJogador = 10; //SerializeField faz a vari�vel aparecer no inspector da Unity

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
                Operador Tern�rio
                    condi��o ? valor a ser atribuido caso verdadeiro : caso falso
         
         */

        resultado = vidaVilao < vidaHeroi ? "Vida Her�i Menor" : "Vida Her�i Maior";

        print(resultado);

        /*
            Estrutura Condicional

        if (vidaHeroi < vidaVilao)
        {
            print("Vida Her�i Menor");
            print("Get Better");
        }
        else if(vidaHeroi == vidaVilao)
        {
            print("Nosso duelo ser� LEND�RIO!!!");
        }
        else
        {
            print("Vida Her�i Maior");
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
        //print(variavelLocal); Da erro, pois a vari�velLocal n�o existe no contexto local
    }
}
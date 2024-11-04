using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercício02 : MonoBehaviour
{
    /*
     
        2. (Detecção de power-up) Ao coletar um power-up, o
        personagem aumenta sua velocidade. Se o jogador encontrar um
        power-up, exiba "Power-up Coletado". Caso contrário, exiba
        "Nenhum power-up encontrado".
     
     */

    [SerializeField] bool powerupColetado;
    public int velocidadePersonagem = 100;


    // Start is called before the first frame update
    void Start()
    {
        if (powerupColetado == true)
        {
            print("Power-up Coletado");
            velocidadePersonagem = 300;
        }
        else
        {
            print("Nenhum power-up encontrado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

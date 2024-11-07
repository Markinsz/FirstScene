using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
    7.Para fazer um jogo de RPG, vamos precisar
calcular probabilidades e simular a rolagem de dados. Crie um
script em que o usuário defina o número de faces de um dado
(int) e calcule a rolagem de um dado com esse número de faces.
Use a função abaixo para o cálculo: Random.Range (valor_min,
valor_max); (Coloque o código dentro da função-evento Start).
 
 */

public class Exercício07 : MonoBehaviour
{

    [SerializeField] int dado;
    int result;

    // Start is called before the first frame update
    void Start()
    {
        result = Random.Range(1, dado);
        print(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
3. (Cálculo de moedas coletadas) O jogador coleta 3 moedas a
cada fase. Após 10 fases, exiba o total de moedas coletadas.
 
 */

public class Execício3 : MonoBehaviour
{
    [SerializeField] int moedas = 0;
    [SerializeField] int FasesTotais = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= FasesTotais; i++)
        {
            moedas += 3;
        }
        print(moedas + " moedas no total!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

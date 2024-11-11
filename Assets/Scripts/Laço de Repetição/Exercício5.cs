using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
5. (Aumento de nível de dificuldade) A cada fase completada, a
dificuldade aumenta em 5 pontos. Exiba a dificuldade após cada
fase, em um total de 6 fases. 

 */

public class Exercício5 : MonoBehaviour
{

    [SerializeField] int fase;
    [SerializeField] int dificuldade;

    // Start is called before the first frame update
    void Start()
    {
        while (fase < 6)
        {  
            fase++;
            dificuldade += 5;
            print("Fase " + fase + "; Dificuldade level " + dificuldade);
        }            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

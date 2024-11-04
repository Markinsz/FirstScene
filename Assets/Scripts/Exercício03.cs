using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercício03 : MonoBehaviour
{
    [SerializeField] bool powerupColetado;
    public int vidaPersonagem = 100;

    // Start is called before the first frame update
    void Start()
    {
        if (powerupColetado == true && vidaPersonagem == 0)
        {
            vidaPersonagem = 50;
            print("Ainda não, vida atual" + vidaPersonagem);
        }
        else if (vidaPersonagem > 0)
        {
            print("Personagem Vivo");
        }
        else
        {
            print("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

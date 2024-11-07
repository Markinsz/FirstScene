using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LacosDeRepeticao : MonoBehaviour
{
    //For - Utilizado quando se sabe a quantidade de repetições

    //While ou DoWhile - É utilizado quando não se sabe a qtd. de repetições

    //Foreach - Quando tem uma lista que para cada elemento que fazer uma operação

    //Array - lista

    // Start is called before the first frame update

    int x = 0;
    int y = 0;

    void Start()
    {
        //for (int i = 0; i <= 10; i++)
            //if (i == 5)
            //{
            //    break;
            //}

            //if (i == 6)
            //{
            //    continue;
            //}

            //while (x <= 10) 
            //{
            //    print(x);
            //    x++;
            //}

            //do
            //{
            //    print(y);
            //    y--;
            //}
            //while (y >= 0);

        int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };

        print(num[3]);
        num[0]++;

        print(num[0]);

        string[] nomes;

        nomes = new string[5];
        nomes[0] = "Tadola";

        print(nomes[1]); //null

            //print(i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections.Generic;
using UnityEngine;

public class ejercicio6S8 : MonoBehaviour
{
    private List<string> enemigos = new List<string>() { "Frezzer", "Cell", "Magin buu", "black goku" };



    void Start()
    {
        foreach (string item in enemigos)

        {

            if (item == "Frezzer" || item == "Cell")
                continue;

            print(item);
        }
    }


    void Update()
    {
        
    }
    }




using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ejercicio : MonoBehaviour
{

    private List<string> nombres = new List<string>() { "Esqueleto", "orco", "Ogro", "Goblimn" };

    void Start()
    {
        foreach (string item in nombres) 
        
        {

            if (item == "orco" || item == "Ogro")
                continue;

            print(item);
        }

   





        /* for (int i = 0; i <= 10; i++) 
         {
             if (i == 5)
                 break;

             Debug.Log(i);
         }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

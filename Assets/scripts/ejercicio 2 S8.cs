using System.Collections.Generic;
using UnityEngine;

public class ejercicio2S8 : MonoBehaviour
{

    private List<string> enemigos = new List<string>() { "Esqueleto", "orco", "Ogro", "Goblimn" };


    void Start()
    {

        for (int i = 0; i < enemigos.Count; i++)
        {
            Debug.Log("enemigos encontrados" + enemigos[i]);
        }

    }

  
    void Update()
    {
        
    }
}

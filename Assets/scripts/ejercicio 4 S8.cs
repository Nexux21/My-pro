using System.Collections.Generic;
using UnityEngine;

public class ejercicio4S8 : MonoBehaviour
{
    private List<int> puntos = new List<int>() { 1, 22, 76, 15 };

    void Start()
    {

        int sumaTotal = 0;

        for (int i = 0; i < puntos.Count; i++)
        {
    
            sumaTotal += puntos[i];

            Debug.Log("Punto actual: " + puntos[i]);
        }

        Debug.Log("La suma total es: " + sumaTotal);
    }
}
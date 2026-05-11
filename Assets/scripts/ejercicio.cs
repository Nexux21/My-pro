using UnityEngine;
using System.Collections.Generic;
//Goku ahhhhhhhhh
public class Ejercicio : MonoBehaviour // Nota: Es buena práctica usar Mayúscula en nombres de clase
{
    public int Count = 50;
    List<string> nombres = new List<string>() { "A", "B", "C", "D", "E" };

    void Start()
    {
        int i = 0;

        // Quitamos el ";" y abrimos llaves
        while (i < nombres.Count)
        {
            Debug.Log(nombres[i]);

            if (nombres[i] == "C")
            {
                Debug.Log("El elemento C se encuentra en la posicion: " + i);
            }

            // El incremento DEBE estar dentro del bucle
            i++;
        }
    }

    void Update()
    {
        // Vacío por ahora
    }
}
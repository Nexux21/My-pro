using UnityEngine;
using System.Collections.Generic;

public class ejercicio5 : MonoBehaviour
{
    public List<string> pociones = new List<string>() { "curacion", "veneno", "mana", "velocidad" };

    void Start()
    {
        Debug.Log("Lista de pociones:");
        int i = 0;

        // Se eliminó el ";" al final de la siguiente línea
        while (i < pociones.Count)
        {
            Debug.Log("Poción encontrada: " + pociones[i]);
            i++; // Es vital que esto ocurra dentro de las llaves
        }

        Debug.Log("Total de pociones en el inventario: " + pociones.Count);
    }
}
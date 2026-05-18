using UnityEngine;

public class ejercicio10 : MonoBehaviour
{
    string[] inventario = { "Poción de Vida", "Escudo de Hierro", "Botas de Velocidad", "Antorcha", "Flecha de Fuego" };

    void Start()
    {
        Debug.Log("--- CONTENIDO DEL INVENTARIO ---");

        
        int i = 0;

        
        while (i < inventario.Length)
        {
            
            Debug.Log("Ranura [" + i + "]: " + inventario[i]);

            
            i++;
        }
    }
}
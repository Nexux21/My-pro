using UnityEngine;

public class ejercicio9  : MonoBehaviour
{
   
    string[] inventario = { "Poción", "Escudo de Madera", "Espada Legendaria", "Cuerda", "Casco de Hierro" };

    void Start()
    {
        Debug.Log("Iniciando búsqueda en el inventario...");

       
        for (int i = 0; i < inventario.Length; i++)
        {
     
            Debug.Log("Revisando ranura " + i + ": " + inventario[i]);

            if (inventario[i] == "Espada Legendaria")
            {
                Debug.Log("¡ÉXITO! Encontrada la 'Espada Legendaria' en la ranura " + i + ".");

               
                break;
            }
        }

        Debug.Log("Búsqueda finalizada.");
    }
}
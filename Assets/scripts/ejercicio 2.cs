using UnityEngine;
using System.Collections.Generic; 

public class ejercicio2 : MonoBehaviour
{
 
    public List<string> miInventario = new List<string>() { "Espada", "Escudo", "Poción", "Llave", "Mapa" };

    void Start()
    {
        Debug.Log("Contenido del Inventario");

        int i = 0; 

       
        while (i < miInventario.Count)
        {

            Debug.Log("Espacio " + i + ": " + miInventario[i]);

            i++;
        }

        Debug.Log("Fin del inventario");
    }
     void Update()
   {

   }
}

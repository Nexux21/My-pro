using UnityEngine;

public class ejercicio3 : MonoBehaviour
{
    void Start()
    {
       int oroActual = 0; 
       int cantidadGanada = 10;

        Debug.Log("Iniciando recolección de oro");

      
        while (oroActual < 100)
        {
            
            oroActual += cantidadGanada;

            
            Debug.Log("Has ganado " + cantidadGanada + " monedas. Oro total: " + oroActual);
        }

        Debug.Log("¡Objetivo alcanzado! Tienes " + oroActual + " de oro.");
    }

        void Update()
     {

   }
}

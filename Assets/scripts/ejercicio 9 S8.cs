using UnityEngine;

public class ejercicio9S8 : MonoBehaviour
{
  
    public int energia = 100;
    public int gastoPorCiclo = 12;

    void Start()
    {
       
        SimularConsumo();
    }

    void SimularConsumo()
    {
        Debug.Log("--- Iniciando Análisis de Consumo ---");

     
        for (int i = 1; i <= 20; i++)
        {
       
            energia -= gastoPorCiclo;

      
            if (energia <= 0)
            {
                energia = 0; 
                Debug.Log("¡BREAK ACTIVADO! Nivel crítico alcanzado en el ciclo: " + i);

                break; 
            }

          
            Debug.Log("Ciclo " + i + " completado. Energía restante: " + energia);
        }

        Debug.Log("--- El bucle ha terminado y el programa continúa aquí ---");
    }
}
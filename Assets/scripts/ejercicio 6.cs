using UnityEngine;

public class ejercicio6 : MonoBehaviour
{

    string[] puntajes = { "16", "17", "18", "19", "20" };

    void Start()
    {

        int i = 0;
        int dañoactual = 1;


        while (i < dañoactual.Length)
        {
           
            Debug.Log("Revisando puntaje en la posición " + i + ": " + puntajes[i]);

  
            i++;
        }

        Debug.Log("Fin del recorrido.");
    }
}
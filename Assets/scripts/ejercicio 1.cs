using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    string[] enemigos = { "Trasgo", "Orco", "Dragón", "Esqueleto", "Mago" };

    void Start()
    {
        int i = 0;
        bool encontrado = false;

        while (i < enemigos.Length && !encontrado)
        {
            Debug.Log("Revisando: " + enemigos[i]);

            if (enemigos[i] == "Dragón")
            {
                Debug.Log("¡Cuidado! El Dragón está en el índice: " + i);
                encontrado = true; 
            }

            i++; 
        }

        if (!encontrado)
        {
            Debug.Log("El Dragón no está en esta zona.");
        }
    }
void Update()
    {

    }
}

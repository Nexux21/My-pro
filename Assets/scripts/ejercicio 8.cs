using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    
    int[] vidasEnemigos = { 100, 0, 45, 0, 80, 12 };

    void Start()
    {
        Debug.Log("--- LISTA DE ENEMIGOS VIVOS ---");

        
        for (int i = 0; i < vidasEnemigos.Length; i++)
        {
            
            if (vidasEnemigos[i] > 0)
            {
                
                Debug.Log("Enemigo [" + i + "] está VIVO con " + vidasEnemigos[i] + " de vida.");
            }
        }
    }
}
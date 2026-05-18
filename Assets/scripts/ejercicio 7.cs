using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
   
    int[] daños = { 24, 34, 77, 50, 999 };

    void Start()
    {
        int i = 0;
        int dañototal = 0; 

        while (i < daños.Length)
        {
            
            dañototal += daños[i];

          
            i++;
        }

      
        Debug.Log("El daño total recibido es: " + dañototal);
    }

    void Update()
    {
        
    }
}
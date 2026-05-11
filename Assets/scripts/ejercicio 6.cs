using UnityEngine;

public class ejercicio6 : MonoBehaviour
{
    string[] puntajes = { "16", "17","18","19","20" };
    void Start()
    {
        int i = 0;

        while (i < puntajes.Length) 
        {
            Debug.Log("revisando puntaje :" + puntajes[1]);

                i++;
        }
        
    }

    void Update()
    {
        
    }
}

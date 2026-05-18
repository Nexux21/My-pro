using UnityEngine;

public class ejercicio5S8 : MonoBehaviour
{
    int[] nivel = new int[] { 10,35, 20, 15, 45 };
    void Start()
    {

        foreach (int nivel in nivel)
        {
            Debug.Log("Nivel desbloqueado: " + nivel);
        }
    }

    void Update()
    {
        
    }
}

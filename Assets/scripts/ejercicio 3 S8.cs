using UnityEngine;

public class ejercicio3S8 : MonoBehaviour
{
  int[] puntajes = new int[] { 100, 80, 10, 60, 45};
    void Start()
    {
        foreach (int punto in puntajes)
        {
            Debug.Log(punto);
        }
    }

    
    void Update()
    {
        
    }
}

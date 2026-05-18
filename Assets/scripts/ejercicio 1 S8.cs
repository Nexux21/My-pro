using UnityEngine;

public class ejercicio1S6 : MonoBehaviour
{
    string [] items = new string[] { "pocion", "espada", "armadura", "escudo ","bloques"};

    void Start()
    {
        foreach (string item in items)
        {
            Debug.Log(item);
        }
    }

    void Update()
    {
        
    }
}

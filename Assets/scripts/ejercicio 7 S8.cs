using UnityEngine;

public class ejercicio7S8 : MonoBehaviour
{
  
    string[] items = new string[] { "pokebola", "trifuerza", "llave", "death note", "pocion" };

    void Start()
    {

        foreach (string item in items)
        {
            Debug.Log("Buscando... Encontrado: " + item);

            if (item == "llave")
            {
                Debug.Log("¡Llave encontrada! Deteniendo búsqueda.");
                break; 
            }
        }
    }

    void Update()
    {
      
    }
}

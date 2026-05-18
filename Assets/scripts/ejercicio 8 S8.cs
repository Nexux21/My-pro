using UnityEngine;

public class ejercicio8S8 : MonoBehaviour
{
  
    void Start()
    {
        for (int i = 0; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
                print(i + " es impar");
        
            
        }
    }



    void Update()
    {
        
    }
}

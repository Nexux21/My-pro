using UnityEngine;

public class ejercicio4 : MonoBehaviour
{
    void Start()
    {

        ValidarPassword();
    }

    void ValidarPassword()
    {
        string intento = ""; 

        do
        {

            Debug.Log("Intentando ingresar con: " + intento);

            if (intento != "admin")
            {
                Debug.Log("Contraseña incorrecta. Sigue pidiendo...");
            }

            intento = "admin";

        } while (intento != "admin");

        Debug.Log("¡Lograste entrar! La contraseña es correcta.");
    }
}


using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuPrincipal : MonoBehaviour
{
    
    public void Jugar()
    {
       
        SceneManager.LoadScene("Nivel1");
    }

    public void Opciones()
    {

        SceneManager.LoadScene("Opciones");
    }
    public void Anterior()
    {

        SceneManager.LoadScene("NuclearThroneUI");
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego...");
    }
}



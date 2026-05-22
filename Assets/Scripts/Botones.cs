
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

/*### 2. Cómo conectarlo en Unity (Sin fallar)
1.  * *Crea un objeto vacío:**En la Jerarquía, haz clic derecho y selecciona **Create Empty**. Ponle de nombre `MenuManager`.
2.  **Ponle el script:**Arrastra tu script `MenuPrincipal` desde la carpeta Project hasta este nuevo objeto `MenuManager`.
3.  **Configura el botón:**
    *Selecciona tu botón de **Jugar**.
    *   En el Inspector, busca abajo donde dice **On Click ()**.
    *   Dale al símbolo **(+)**.
    *   Arrastra el objeto `MenuManager` (el que creaste en el paso 1) al cuadro vacío que dice "None (Object)".
    *   En el desplegable de al lado ("No Function"), busca **MenuPrincipal > Jugar()**.

### 3. ¡El paso que todos olvidan!
Para que `SceneManager` funcione, tienes que avisarle a Unity qué escenas existen en tu juego:
1.Ve a** File > Build Settings**.
2.  Arrastra tu escena de **Menú** y tu escena de **Juego** (Nivel1) al cuadro superior que dice "Scenes In Build".
3.  Asegúrate de que el Menú esté en la posición **0**.

¡Tu menú de inicio ya debería funcionar perfectamente! ¿Quieres que te ayude a crear el panel de Opciones para que aparezca y desaparezca al pulsar el botón?*/

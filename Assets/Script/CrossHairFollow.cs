using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class CrossHairFollow : MonoBehaviour
{
    private RectTransform crossHairRect; // los que estan adentro del canva usan rectTransform
    void Awake()
    {
        crossHairRect = GetComponent<RectTransform>();
        Cursor.visible = false; //oculta cursor.
        Cursor.lockState = CursorLockMode.Confined; // hace que no pueda salir de la pantalla
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current == null) //chequeo que haya mouse
        {
            return;
        }
        Vector2 mousePos = Mouse.current.position.ReadValue(); //leo posicion del mouse y que me devuelva un vector 2
        crossHairRect.position = mousePos; // y esto es para tener cursos que me sigue
    }
}

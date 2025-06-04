using UnityEngine;
using UnityEngine.InputSystem;

public class CrossHairFollow : MonoBehaviour
{
    private RectTransform crossHairRect;
    void Awake()
    {
        crossHairRect = GetComponent<RectTransform>();
        Cursor.visible = false; //oculta cursor.
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current == null)
        {
            return;
        }
        Vector2 mousePos = Mouse.current.position.ReadValue();
        crossHairRect.position = mousePos;
    }
}

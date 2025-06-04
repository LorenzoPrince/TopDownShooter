using UnityEngine;

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
        
    }
}

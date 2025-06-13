using UnityEngine;
using System;
public class Bullet : MonoBehaviour
{
    public static event Action<GameObject, float> OnHit; // Evento: objeto impactado y da�o
    [SerializeField] private float damage = 0.2f;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Bala impact� a: {collision.gameObject.name}");
        // Lanzar el evento notificando qu� objeto recibi� el impacto y cu�nto da�o
        OnHit?.Invoke(collision.gameObject, damage);

        Destroy(gameObject);
    }
}


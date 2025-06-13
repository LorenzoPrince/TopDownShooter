using UnityEngine;
using System;
public class Bullet : MonoBehaviour
{
   // public static event Action<GameObject, float> OnHit; // Evento: objeto impactado y daño
    public float damage = 25f;

    //private void OnCollisionEnter(Collision collision)
    //{
      //  Debug.Log($"Bala impactó a: {collision.gameObject.name}");
        // Lanzar el evento notificando qué objeto recibió el impacto y cuánto daño
        //OnHit?.Invoke(collision.gameObject, damage);

        //Destroy(gameObject);
    //}
}


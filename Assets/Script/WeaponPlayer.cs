using UnityEngine;

public class WeaponPlayer : MonoBehaviour
{

    //public AudioSource blaster;         // Asigna el audio en el Inspector
    [SerializeField] private float bulletForce; //es para que sea privado pero se siga viendo en el inspector y editarlo, pero no podes editarlo en otro script. 
    [SerializeField] private GameObject objectPrefab;
    // [SerializeField] private GameObject shootVFXPrefab; // Prefab de las part�culas del disparo
    public Vector3 spawnPosition;
    public Transform playerBody; // donde semmueve el personajke
    [SerializeField] private Transform spawnPoint;

    //private AudioSource audioSource;



    public void OnShoot()
    {
        Weapon();
    }


    void Weapon()
    {


        GameObject bulletClone = Instantiate(objectPrefab, spawnPoint.position, spawnPoint.rotation); // el quaternion. identity es para que sea en la misma posicion que el vector . y el vector que esta el spawn


        Rigidbody bulletRigidBody = bulletClone.GetComponent<Rigidbody>(); //rigid body de la nueva bala

        bulletRigidBody.linearVelocity = playerBody.forward * bulletForce; // impulso de la bala multiplicado por el bulletforce


 

        Destroy(bulletClone, 1.3f);
     
    }

}

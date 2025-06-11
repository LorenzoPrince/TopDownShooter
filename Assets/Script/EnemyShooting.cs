using UnityEngine;

public class EnemyShooting : Shooting
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(EnemeyShoot), 2f, 2f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnemeyShoot()
    {
        Debug.Log("Enemy Shooting");
        Shoot();
    }
}

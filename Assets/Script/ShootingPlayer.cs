using UnityEngine;
using UnityEngine.InputSystem;
public class ShootingPlayer : Shooting
{
    public void Onfire(InputAction.CallbackContext context)
    {
  
            Shoot();
    }
}

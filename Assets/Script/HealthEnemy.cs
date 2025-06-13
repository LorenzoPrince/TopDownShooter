using UnityEngine;
using UnityEngine.UI;
public class HealthEnemy : MonoBehaviour
{
    [SerializeField] private GameObject enemyUIPrefab;
    [SerializeField] Image healthBar;
    [Range(0, 1)] public float health = 1f;
    public float healthTotal;
    private Canvas HUDCanvas;
    private GameObject enemyUIClone;

    private void Awake()
    {
        HUDCanvas = GameObject.Find("HUD").GetComponent<Canvas>();
        // Suscribirse al evento de la bala
        Bullet.OnHit += OnBulletHit;
    }

    void Start()
    {
        enemyUIClone = Instantiate(enemyUIPrefab, HUDCanvas.transform);
        enemyUIClone.transform.SetParent(HUDCanvas.transform, false);

        healthBar = enemyUIClone.transform.Find("ImageEnemy").GetComponent<Image>();
        UpdateHealthBar(health);
    }

    // Update is called once per frame
   // void Update()
    //{
      //  UpdateHealthBar(health); //lo llamamos desdde le saque vida
    //}
    private void OnDestroy()
    {
        // Desuscribirse para evitar memory leaks
        Bullet.OnHit -= OnBulletHit;

        if (enemyUIClone != null)
            Destroy(enemyUIClone);
    }
    public void UpdateHealthBar(float health)
    {
        healthBar.fillAmount = health;
    } //health debe estar entre 0 y 1 
    private void Die()
    {
        // Aquí pon animación, efectos o lógica de muerte
        Destroy(gameObject);
        if (enemyUIClone != null)
            Destroy(enemyUIClone);
    }
    private void OnBulletHit(GameObject hitObject, float damage)
    {
        Debug.Log($"Enemy recibió daño: {damage} de {hitObject.name}");
        HealthEnemy enemy = hitObject.GetComponentInParent<HealthEnemy>();
        if (enemy == this)
        {
            health -= damage;
            health = Mathf.Clamp01(health);
            Debug.Log($"Health actualizado: {health}");  //VERIFICÁ QUE SALE ESTO
            UpdateHealthBar(health);

            if (health <= 0)
            {
                Die();
            }
        }
    }

}

using UnityEngine;
using UnityEngine.AI;
public class enemyMovementController : MonoBehaviour
{
    public Transform playerTransform; //referencia jugador
    private NavMeshAgent navMeshAgent;
    [SerializeField] private float refreshRate = 0.5f; // frecuencia de actualizacion del enemigo

    private void Awake()
    {
        playerTransform = GameObject.FindWithTag("Player")?.transform; // esto ? es si no es null lo guarde
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        InvokeRepeating("FindPlayer", 0f, refreshRate); // llamada al metodo cada refresh segundos
    }
    // Update is called once per frame
    public void FindPlayer()
    {
        navMeshAgent.SetDestination(playerTransform.position); //mueve el enemigo hacia el jugador
    }
}

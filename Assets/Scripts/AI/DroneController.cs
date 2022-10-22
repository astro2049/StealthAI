using UnityEngine;
using UnityEngine.AI;

public class DroneController : MonoBehaviour
{
    [SerializeField] public Transform movePositionTransform;
    public NavMeshAgent navMeshAgent;
    [SerializeField] private string currentStateName;
    public ChaseState chaseState = new();
    private IDroneState currentState;

    public LookAroundState lookAroundState = new();
    public PatrolState patrolState = new();

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        currentState = currentState.DoState(this);
        currentStateName = currentState.ToString();
    }

    private void OnEnable()
    {
        currentState = patrolState;
    }
}
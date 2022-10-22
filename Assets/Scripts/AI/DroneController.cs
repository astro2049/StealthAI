using UnityEngine;
using UnityEngine.AI;

public class DroneController : MonoBehaviour
{
    [SerializeField] public Transform movePositionTransform;
    public NavMeshAgent navMeshAgent;
    [SerializeField] private string currentStateName;

    private IDroneState currentState;
    private IdleState idleState = new();
    public ChaseState chaseState = new();
    public LookAroundState lookAroundState = new();
    public PatrolState patrolState = new();

    public Vector3 initialPosition;
    public float patrolRadius = 15;
    public float lookAroundCountDown = 0;

    private void Awake()
    {
        initialPosition = transform.position;
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void OnEnable()
    {
        currentState = idleState;
    }
    
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        var nextState = currentState.DoState(this);
        if (currentState == nextState)
        {
            currentState = nextState;
        }
        else
        {
            currentState.onExit(this);
            currentState = nextState;
            currentState.onEnter(this);
        }

        currentStateName = currentState.ToString();
    }
}
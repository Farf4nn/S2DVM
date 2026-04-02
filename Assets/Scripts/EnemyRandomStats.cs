using UnityEngine;
using UnityEngine.AI;

public class EnemyRandomStats : MonoBehaviour
{
    private NavMeshAgent agent;

    [Header("Rangos")]
    public float minSpeed = 3f;
    public float maxSpeed = 6f;

    public float minAcceleration = 4f;
    public float maxAcceleration = 10f;

    public float minAngularSpeed = 80f;
    public float maxAngularSpeed = 200f;

    public float minStoppingDistance = 1f;
    public float maxStoppingDistance = 3f;

    public int minPriority = 10;
    public int maxPriority = 90;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();

        RandomizeStats();
    }

    void RandomizeStats()
    {
        agent.speed = Random.Range(minSpeed, maxSpeed);
        agent.acceleration = Random.Range(minAcceleration, maxAcceleration);
        agent.angularSpeed = Random.Range(minAngularSpeed, maxAngularSpeed);
        agent.stoppingDistance = Random.Range(minStoppingDistance, maxStoppingDistance);
        agent.avoidancePriority = Random.Range(minPriority, maxPriority);

        Debug.Log("Stats randomizados en: " + gameObject.name);
    }
}

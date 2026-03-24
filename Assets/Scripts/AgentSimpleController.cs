using UnityEngine;
using UnityEngine.AI;

public class AgentSimpleController : MonoBehaviour
{
    public Transform Target;
    private NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Target != null)
        {
            agent.SetDestination(Target.position);

            agent.speed = Random.Range(3f, 6f);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        if (agent == null || agent.path == null) return;

        Vector3[] corners = agent.path.corners;

        for (int i = 0; i < corners.Length; i++)
        {
            Gizmos.DrawLine(corners[i], corners[i + 1]);
            Gizmos.DrawSphere(corners[i], 0.2f);
        }
    }
}

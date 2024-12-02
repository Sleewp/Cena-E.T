using UnityEngine;

public class agent : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 5f;
    public float reachDistance = 0.5f; // Distância para considerar o waypoint alcançado

    public int currentWaypointIndex = 0; // Índice do waypoint atual

    private Quaternion defaultRotation;
    private Vector3 defaultPosition;

    void Start()
    {
        defaultRotation = transform.rotation;
        defaultPosition = transform.position;
    }
    void Update()
    {
        FollowPath();
    }

    private void FollowPath()
    {
        // Verifica se há waypoints definidos, caso contrário não executa o método
        if (waypoints.Length == 0) return;

        // Pega o waypoint atual
        Transform targetWaypoint = waypoints[currentWaypointIndex];

        // Move em direção ao waypoint atual
        Vector3 direction = (targetWaypoint.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        // Rotaciona a viatura para olhar para o waypoint
        transform.LookAt(targetWaypoint);

        // Verifica se a viatura alcançou o waypoint
        if (Vector3.Distance(transform.position, targetWaypoint.position) <= reachDistance)
        {
            currentWaypointIndex++; // Passa para o próximo waypoint
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Reseta a posição do agent para a posição inicial
            resetPosition();
        }
    }

    public void resetPosition()
    {
        transform.position = defaultPosition;
        transform.rotation = defaultRotation;
        currentWaypointIndex = 0;
    }
}

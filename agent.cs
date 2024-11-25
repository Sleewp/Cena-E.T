using UnityEngine;

public class agent : MonoBehaviour
{
    public Transform[] waypoints; // Lista de waypoints
    public float speed = 5f;      // Velocidade da viatura
    public float reachDistance = 0.5f; // Distância para considerar o waypoint alcançado

    private int currentWaypointIndex = 0; // Índice do waypoint atual

    void Update()
    {
        FollowPath(); // Chama o método para seguir o caminho
    }

    private void FollowPath()
    {
        // Verifica se há waypoints definidos
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

            // Volta ao início ou para no último waypoint
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0; // Reinicia o caminho (opcional)
                // Se não quiser reiniciar o caminho, comente a linha acima.
            }
        }
    }
}

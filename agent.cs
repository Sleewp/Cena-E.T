using UnityEngine;

public class agent : MonoBehaviour
{
    public Transform[] waypoints; // Lista de waypoints
    public float speed = 5f;      // Velocidade da viatura
    public float reachDistance = 0.5f; // Dist�ncia para considerar o waypoint alcan�ado

    private int currentWaypointIndex = 0; // �ndice do waypoint atual

    void Update()
    {
        FollowPath(); // Chama o m�todo para seguir o caminho
    }

    private void FollowPath()
    {
        // Verifica se h� waypoints definidos
        if (waypoints.Length == 0) return;

        // Pega o waypoint atual
        Transform targetWaypoint = waypoints[currentWaypointIndex];

        // Move em dire��o ao waypoint atual
        Vector3 direction = (targetWaypoint.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        // Rotaciona a viatura para olhar para o waypoint
        transform.LookAt(targetWaypoint);

        // Verifica se a viatura alcan�ou o waypoint
        if (Vector3.Distance(transform.position, targetWaypoint.position) <= reachDistance)
        {
            currentWaypointIndex++; // Passa para o pr�ximo waypoint

            // Volta ao in�cio ou para no �ltimo waypoint
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0; // Reinicia o caminho (opcional)
                // Se n�o quiser reiniciar o caminho, comente a linha acima.
            }
        }
    }
}

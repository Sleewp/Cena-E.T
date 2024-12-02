using UnityEngine;

public class Walls : MonoBehaviour
{
    public Transform playerObject; // Refer�ncia ao jogador
    public Transform agentObject; // Refer�ncia ao agent
    private Vector3 playerStartPos; // Posi��o inicial do jogador
    private Vector3 targetStartPos; // Posi��o inicial do agent


    private void Start()
    {
        // Armazena as posi��es iniciais, se n�o forem configuradas manualmente
        if (playerObject != null) playerStartPos = playerObject.position;
        if (agentObject != null) targetStartPos = agentObject.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se o jogador colidiu
        if (collision.gameObject.CompareTag("Player"))
        {
            // Reseta as posi��es
            if (playerObject != null)
            {
                player playerScript = playerObject.GetComponent<player>();
                if (playerScript != null)
                {
                    playerScript.resetPosition();
                }
                if (agentObject != null)
                {
                    agent agentScript = agentObject.GetComponent<agent>();
                    if (agentScript != null)
                    {
                        agentScript.resetPosition();
                    }
                }
            }
        }
    }
}

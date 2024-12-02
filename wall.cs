using UnityEngine;

public class Walls : MonoBehaviour
{
    public Transform playerObject; // Referência ao jogador
    public Transform agentObject; // Referência ao agent
    private Vector3 playerStartPos; // Posição inicial do jogador
    private Vector3 targetStartPos; // Posição inicial do agent


    private void Start()
    {
        // Armazena as posições iniciais, se não forem configuradas manualmente
        if (playerObject != null) playerStartPos = playerObject.position;
        if (agentObject != null) targetStartPos = agentObject.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se o jogador colidiu
        if (collision.gameObject.CompareTag("Player"))
        {
            // Reseta as posições
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

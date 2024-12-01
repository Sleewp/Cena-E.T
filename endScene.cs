using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnCollision : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se o jogador colidiu
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Scenes/Fim"); // Carrega a cena especificada
        }
    }
}

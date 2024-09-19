using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseGameAfterSceneLoad : MonoBehaviour
{
    void OnEnable()
    {
        // Inscreve-se no evento que detecta quando uma nova cena � carregada
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        // Remove a inscri��o no evento quando o objeto for desativado ou destru�do
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // Fun��o chamada quando uma nova cena � carregada
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Invoca o fechamento do jogo ap�s 4 segundos
        Invoke("CloseGame", 4f);
    }

    // Fun��o que fecha o jogo
    void CloseGame()
    {
        // Fecha o jogo
        Application.Quit();

        // No editor do Unity, isso n�o funciona, ent�o usamos isso para simular
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}

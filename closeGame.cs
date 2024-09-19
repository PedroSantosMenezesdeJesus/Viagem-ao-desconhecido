using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseGameAfterSceneLoad : MonoBehaviour
{
    void OnEnable()
    {
        // Inscreve-se no evento que detecta quando uma nova cena é carregada
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        // Remove a inscrição no evento quando o objeto for desativado ou destruído
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // Função chamada quando uma nova cena é carregada
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Invoca o fechamento do jogo após 4 segundos
        Invoke("CloseGame", 4f);
    }

    // Função que fecha o jogo
    void CloseGame()
    {
        // Fecha o jogo
        Application.Quit();

        // No editor do Unity, isso não funciona, então usamos isso para simular
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}

using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para acessar o SceneManager

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;

    public string cenaParaDestruir; // Nome da cena onde o objeto será destruído

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        // Verifica se a cena atual é a que deve destruir o objeto
        if (SceneManager.GetActiveScene().name == cenaParaDestruir)
        {
            Destroy(gameObject); // Destrói o objeto na cena especificada
        }
    }
}

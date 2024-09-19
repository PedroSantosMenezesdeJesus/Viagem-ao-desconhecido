using UnityEngine;
using UnityEngine.SceneManagement; // Necess�rio para acessar o SceneManager

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;

    public string cenaParaDestruir; // Nome da cena onde o objeto ser� destru�do

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
        // Verifica se a cena atual � a que deve destruir o objeto
        if (SceneManager.GetActiveScene().name == cenaParaDestruir)
        {
            Destroy(gameObject); // Destr�i o objeto na cena especificada
        }
    }
}

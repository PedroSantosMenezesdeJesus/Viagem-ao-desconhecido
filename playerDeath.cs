using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDeath : MonoBehaviour
{
    public AudioSource morteAudioSource;
    public string sceneName;
    private bool inChekpoint;
    Vector3 posicaoRespawn;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            morteAudioSource.Play();
            Invoke("trocaCena", 0.2f);
        }

    }
    void trocaCena()
    {
       
           SceneManager.LoadScene("Scenes/Scene2");

    }
}

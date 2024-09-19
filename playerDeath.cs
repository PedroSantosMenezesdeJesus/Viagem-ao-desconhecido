using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDeath : MonoBehaviour
{
    public AudioSource morteAudioSource;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            morteAudioSource.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

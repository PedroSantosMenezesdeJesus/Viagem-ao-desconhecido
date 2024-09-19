using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPrincipalManager : MonoBehaviour
{
    public string scene;
    public GameObject painelMenu;
    public GameObject painelOpcoes;
    public void Jogar()
    {
        SceneManager.LoadScene(scene);
    }

    public void abrirOpcoes()
    {
        painelMenu.SetActive(false);
        painelOpcoes.SetActive(true);
    }
    public void fecharopcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenu.SetActive(true);
    }
    public void sairJogo()
    {
        Debug.Log("sair do jogo");
        Application.Quit();
    }
}

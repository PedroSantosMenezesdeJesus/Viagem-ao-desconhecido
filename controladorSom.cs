using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controladorSom : MonoBehaviour
{
    private bool estadoSom = true;
    public AudioSource fundoMusical;

    public Sprite somLigadoSprite;
    public Sprite somDesligadoSprite;

    public Image muteImage;
    public void ligarDesligarSom()
    {
        estadoSom = !estadoSom;
        fundoMusical.enabled = estadoSom;

        if (estadoSom)
        {
            muteImage.sprite = somLigadoSprite;
        }
        else
        {
            muteImage.sprite = somDesligadoSprite;
        }
    }
    public void volumeMusical(float value)
    {
        fundoMusical.volume = value;
    }
}

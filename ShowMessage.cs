using UnityEngine;
using TMPro;

public class ShowMessage : MonoBehaviour
{
    public TMP_Text messageText;
    public float displayTime = 5f;

    private void Start()
    {
        if(messageText != null)
        {
            messageText.gameObject.SetActive(true);
            Invoke("HideMessage", displayTime);
        }
    }
    private void HideMessage()
    {
        if(messageText !=null)
        {
            messageText.gameObject.SetActive(false);
        }
    }
}

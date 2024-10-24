using TMPro;
using UnityEngine;

public class ImprimanteBehaviour : MonoBehaviour
{
    public TMP_Text screenText;
    public bool isPrinting;
    public GameObject printButton;

    void Start()
    {
        printButton.SetActive(false);
    }

    public void StartPrinting()
    {
        if (!isPrinting)
        {
            screenText.text = "Impression...";
            isPrinting = true;
        }
    }

    public void ShowPrintButton()
    {
        printButton.SetActive(true);
    }
}
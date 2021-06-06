using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowPopup : MonoBehaviour
{
    public GameObject popup;

    public TMP_Text popupText;
    public TMP_Text buttonText;

    public void ShowFinalPopup()
    {
        popupText.text = "You have successfully finished the Cazillionaire quiz!";
        buttonText.text = "[ Ok, thank you ]";

        popup.SetActive(true);

        Debug.Log("Quiz Finished");
    }
}

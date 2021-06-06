using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Screen5Manage : MonoBehaviour
{
    public Animator popupAnimation;
    public GameObject popup;
    public ShowPopup showPopup;

    TMP_Text popupText;
    TMP_Text buttonText;

    GameObject inputFieldName;
    GameObject inputFieldEmail;

    string inputFieldNameText = "";
    string inputFieldEmailText = "";

    void Start()
    {
        popupText = GameObject.Find("PopupText").GetComponent<TMP_Text>();
        buttonText = GameObject.Find("ButtonText").GetComponent<TMP_Text>();

        popup.SetActive(false);
    }

    public void ReadNameInput(string name)
    {
        inputFieldNameText = name;
        // Debug.Log("inputFieldNameText: " + inputFieldNameText);
    }

    public void ReadEmailInput(string email)
    {
        inputFieldEmailText = email;
        // Debug.Log("inputFieldEmailText: " + inputFieldEmailText);
    }

    public void CheckData()
    {
        if (inputFieldNameText == "" || inputFieldEmailText == "")
        {
            popupText.text = "Please specify your Name and Email in format name@domain!";
            buttonText.text = "[ Ah, I'll fix it ]";

            popup.SetActive(true);
            popupAnimation.SetTrigger("RunPopup");            
        }
        else
        {
            showPopup.ShowFinalPopup();
            popupAnimation.SetTrigger("RunPopup");
        }
    }

    public void ClosePopup()
    {
        popup.SetActive(false);
    }
}

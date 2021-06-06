using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen3Manage : MonoBehaviour
{
    GameObject musicIcon;

    GameObject question_3;
    GameObject buttonMaybeNo;
    GameObject buttonMaybeYes;
    GameObject buttonDefinitelyNo;
    GameObject buttonSomethingScratches;
    GameObject buttonYes;
    GameObject buttonNo;
    GameObject buttonPrikol;

    float musicLength = 19f;
    float currentTimestamp = 0f;
    float targetTimestamp = 15f;

    void Start()
    {
        musicIcon = GameObject.Find("MusicIcon");

        question_3 = GameObject.Find("Question-3");
        buttonMaybeNo = GameObject.Find("ButtonMaybeNo");
        buttonMaybeYes = GameObject.Find("ButtonMaybeYes");
        buttonDefinitelyNo = GameObject.Find("ButtonDefinitelyNo");
        buttonSomethingScratches = GameObject.Find("ButtonSomethingScratches");
        buttonYes = GameObject.Find("ButtonYes");
        buttonNo = GameObject.Find("ButtonNo");
        buttonPrikol = GameObject.Find("ButtonPrikol");

        question_3.SetActive(false);
        buttonMaybeNo.SetActive(false);
        buttonMaybeYes.SetActive(false);
        buttonDefinitelyNo.SetActive(false);
        buttonSomethingScratches.SetActive(false);
        buttonYes.SetActive(false);
        buttonNo.SetActive(false);
        buttonPrikol.SetActive(false);
    }

    void Update()
    {
        currentTimestamp += Time.deltaTime;

        CheckTimestamp();
    }

    void CheckTimestamp()
    {
        if (currentTimestamp >= targetTimestamp)
        {
            question_3.SetActive(true);
        }

        if (currentTimestamp >= musicLength)
        {
            musicIcon.SetActive(false);

            buttonMaybeNo.SetActive(true);
            buttonMaybeYes.SetActive(true);
            buttonDefinitelyNo.SetActive(true);
            buttonSomethingScratches.SetActive(true);
            buttonYes.SetActive(true);
            buttonNo.SetActive(true);
            buttonPrikol.SetActive(true);
        }
    }
}

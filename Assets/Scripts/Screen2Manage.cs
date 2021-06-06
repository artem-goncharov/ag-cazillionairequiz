using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen2Manage : MonoBehaviour
{
    GameObject videoBorder;
    GameObject videoImage;
    GameObject videoPlayer;

    GameObject question_2;
    GameObject buttonMnogo;
    GameObject buttonMalo;
    GameObject buttonNoGreen;

    float videoLength = 9f;
    float currentTimestamp = 0f;
    float targetTimestamp = 5f;

    void Start()
    {
        videoBorder = GameObject.Find("VideoBorder");
        videoImage = GameObject.Find("VideoImage");
        videoPlayer = GameObject.Find("VideoPlayer");

        question_2 = GameObject.Find("Question-2");
        buttonMnogo = GameObject.Find("ButtonMnogo");
        buttonMalo = GameObject.Find("ButtonMalo");
        buttonNoGreen = GameObject.Find("ButtonNoGreen");

        question_2.SetActive(false);
        buttonMnogo.SetActive(false);
        buttonMalo.SetActive(false);
        buttonNoGreen.SetActive(false);
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
            question_2.SetActive(true);
        }

        if (currentTimestamp >= videoLength)
        {
            videoBorder.SetActive(false);
            videoImage.SetActive(false);
            videoPlayer.SetActive(false);

            buttonMnogo.SetActive(true);
            buttonMalo.SetActive(true);
            buttonNoGreen.SetActive(true);
        }
    }
}

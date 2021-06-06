using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen1Manage : MonoBehaviour
{
    public QuizData quizData;

    void Start()
    {
        quizData.ResetQuizData();
    }
}

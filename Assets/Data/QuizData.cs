using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuizDataObject", menuName = "QuizData", order = 1)]
public class QuizData : ScriptableObject
{
    [SerializeField] public int scoreScreen1;
    [SerializeField] public int scoreScreen2;
    [SerializeField] public int scoreScreen3;
    [SerializeField] public int scoreScreen4;

    [SerializeField] public string valueScreen1;
    [SerializeField] public string valueScreen2;
    [SerializeField] public string valueScreen3;
    [SerializeField] public string valueScreen4;

    public void ResetQuizData()
    {
        scoreScreen1 = 0;
        scoreScreen2 = 0;
        scoreScreen3 = 0;
        scoreScreen4 = 0;

        valueScreen1 = "";
        valueScreen2 = "";
        valueScreen3 = "";
        valueScreen4 = "";
    }
}

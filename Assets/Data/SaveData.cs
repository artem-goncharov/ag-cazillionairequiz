using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveData : MonoBehaviour
{
    public QuizData quizData;
    public LevelLoader levelLoader;

    GameObject buttonPressed;
    string buttonPressedText;

    public void SaveScreen1 (int buttonIndex)
    {
        var scoreButton5000 = 100;
        var scoreButton50000 = 200;
        var scoreButton500millions = 300;
        var scoreButton100500 = 400;

        buttonPressed = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        buttonPressedText = buttonPressed.GetComponentInChildren<TMP_Text>().text.ToString();
        // Debug.Log("Pressed button: " + buttonPressed);
        // Debug.Log("Button Text: " + buttonPressedText);

        if (buttonIndex == 0) { quizData.scoreScreen1 = scoreButton5000; }
        if (buttonIndex == 1) { quizData.scoreScreen1 = scoreButton50000; }
        if (buttonIndex == 2) { quizData.scoreScreen1 = scoreButton500millions; }
        if (buttonIndex == 3) { quizData.scoreScreen1 = scoreButton100500; }

        quizData.valueScreen1 = buttonPressedText;

        levelLoader.LoadNextLevel();
    }

    public void SaveScreen2 (int buttonIndex)
    {
        var scoreButtonMnogo = 100;
        var scoreButtonMalo = 200;
        var scoreButtonNoGreen = 300;

        buttonPressed = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        buttonPressedText = buttonPressed.GetComponentInChildren<TMP_Text>().text.ToString();
        // Debug.Log("Pressed button: " + buttonPressed);
        // Debug.Log("Button Text: " + buttonPressedText);

        if (buttonIndex == 0) { quizData.scoreScreen2 = scoreButtonMnogo; }
        if (buttonIndex == 1) { quizData.scoreScreen2 = scoreButtonMalo; }
        if (buttonIndex == 2) { quizData.scoreScreen2 = scoreButtonNoGreen; }

        quizData.valueScreen2 = buttonPressedText;

        levelLoader.LoadNextLevel();
    }

    public void SaveScreen3 (int buttonIndex)
    {
        var scoreButtonMaybeNo = 100;
        var scoreButtonMaybeYes = 200;
        var scoreButtonDefinitelyNo = 300;
        var scoreButtonSomethingScratches = 400;
        var scoreButtonYes = 500;
        var scoreButtonNo = 600;
        var scoreButtonPrikol = 700;

        buttonPressed = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        buttonPressedText = buttonPressed.GetComponentInChildren<TMP_Text>().text.ToString();
        // Debug.Log("Pressed button: " + buttonPressed);
        // Debug.Log("Button Text: " + buttonPressedText);

        if (buttonIndex == 0) { quizData.scoreScreen3 = scoreButtonMaybeNo; }
        if (buttonIndex == 1) { quizData.scoreScreen3 = scoreButtonMaybeYes; }
        if (buttonIndex == 2) { quizData.scoreScreen3 = scoreButtonDefinitelyNo; }
        if (buttonIndex == 3) { quizData.scoreScreen3 = scoreButtonSomethingScratches; }
        if (buttonIndex == 4) { quizData.scoreScreen3 = scoreButtonYes; }
        if (buttonIndex == 5) { quizData.scoreScreen3 = scoreButtonNo; }
        if (buttonIndex == 6) { quizData.scoreScreen3 = scoreButtonPrikol; }

        quizData.valueScreen3 = buttonPressedText;

        levelLoader.LoadNextLevel();
    }

    public void SaveScreen4 (int buttonIndex)
    {
        var scoreButtonZubr = 100;
        var scoreButtonPalets = 200;
        var scoreButtonMagazin = 300;
        var scoreButton100rubley = 400;

        buttonPressed = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        buttonPressedText = buttonPressed.GetComponentInChildren<TMP_Text>().text.ToString();
        // Debug.Log("Pressed button: " + buttonPressed);
        // Debug.Log("Button Text: " + buttonPressedText);

        if (buttonIndex == 0) { quizData.scoreScreen4 = scoreButtonZubr; }
        if (buttonIndex == 1) { quizData.scoreScreen4 = scoreButtonPalets; }
        if (buttonIndex == 2) { quizData.scoreScreen4 = scoreButtonMagazin; }
        if (buttonIndex == 3) { quizData.scoreScreen4 = scoreButton100rubley; }

        quizData.valueScreen4 = buttonPressedText;

        levelLoader.LoadNextLevel();
    }
}

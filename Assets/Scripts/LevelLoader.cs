using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 0.5f;

    void start()
    {
        transition = GetComponent<Animator>();
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        if (transition)
        {
            transition.SetTrigger("LevelLoad");
        }

        yield return new WaitForSeconds(transitionTime);

        if (levelIndex < 5)
        {
            SceneManager.LoadScene(levelIndex);
        }
    }
}

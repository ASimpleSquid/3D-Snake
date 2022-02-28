using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayButtonBehaviour : MonoBehaviour
{
    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene("GameplayScene");
        Time.timeScale = 1f;
    }

    public void OnReplayButtonPressed()
    {
        SceneManager.GetActiveScene(); SceneManager.LoadScene("GameplayScene");
        Time.timeScale = 1f;
    }
}
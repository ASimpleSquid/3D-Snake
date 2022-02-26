using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class CreditsButtonBehaviour : MonoBehaviour
{
    public void OnCreditsButtonPressed()
    {
        SceneManager.LoadScene("CreditsScene");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class BackButtonBehaviour : MonoBehaviour
{
    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
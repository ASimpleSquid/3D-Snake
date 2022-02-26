using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionnButtonBehaviour : MonoBehaviour
{
    public void OnInstructionButtonPressed()
    {
        SceneManager.LoadScene("InstructionScene");
    }
}
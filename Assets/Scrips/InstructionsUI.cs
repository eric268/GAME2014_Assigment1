using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class InstructionsUI : MonoBehaviour
{
    [SerializeField]
    private Canvas mainCanvas;

    [SerializeField]
    private Canvas secondCanvas;

    [SerializeField]
    private Canvas thirdCanvas;
    // Start is called before the first frame update
    void Start()
    {
        mainCanvas.enabled = true;
        secondCanvas.enabled = false;
        thirdCanvas.enabled = false;
    }

    public void OnPage1NextPressed()
    {
        mainCanvas.enabled = false;
        secondCanvas.enabled = true;
    }
    public void OnPage2NextPressed()
    {
        secondCanvas.enabled = false;
        thirdCanvas.enabled = true;
    }

    public void OnPage2PreviousPressed()
    {
        secondCanvas.enabled = false;
        mainCanvas.enabled = true;
    }

    public void OnPage3PreviousPressed()
    {
        thirdCanvas.enabled = false;
        secondCanvas.enabled = true;
    }

    public void OnReturnToMainMenuPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

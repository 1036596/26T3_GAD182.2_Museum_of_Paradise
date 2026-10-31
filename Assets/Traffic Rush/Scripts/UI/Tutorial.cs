using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Tutorial : MonoBehaviour
{

    public GameObject tutorialPanel;

    public GameObject goPrompt;
    public bool gameStarted = false;

    public float timerTutorial = 5f;

    public float startGameGoTextTimer = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tutorialPanel.SetActive(true);
        goPrompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StartGame();

        RunStarted();
    }

    public void StartGame()
    {
        if (timerTutorial > 0)
        {
            timerTutorial -= Time.deltaTime;
        }

        // When timer reaches appearTime, show the object
        if (timerTutorial <= 0)
        {
            tutorialPanel.SetActive(false);
            goPrompt.SetActive(true);
            gameStarted = true;
            Debug.Log("Tutorial Closed");
        }
    }

    public void RunStarted()
    {
        if (startGameGoTextTimer > 0 && gameStarted == true)
        {
            startGameGoTextTimer -= Time.deltaTime;
        }

        if (startGameGoTextTimer <= 0 && gameStarted == true)
        {
            goPrompt.SetActive(false);
        }
    }
}

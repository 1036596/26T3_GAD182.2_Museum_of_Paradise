using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Late : MonoBehaviour
{

    public Timer timerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LateToWork();
    }

    public void LateToWork()
    {
        if (timerScript.timeValue <= 0)
        {
            Debug.Log("You are late to work");
            SceneManager.LoadScene("Fired");
        }
    }
}

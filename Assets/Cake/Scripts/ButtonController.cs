using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private SpriteRenderer TheSR;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keyToPress;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TheSR = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            TheSR.sprite = pressedImage;
        }

        if (Keyboard.current.upArrowKey.wasReleasedThisFrame)
        {
            TheSR.sprite = defaultImage;
        }
    }
}

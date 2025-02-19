using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RockPaperScissors : MonoBehaviour
{
    // SerializedField allows a value to be accessed within the Inspector (so we can drag & drop out button into this script)
    [SerializeField]
    TMP_Text txtWelcome;

    [SerializeField]
    TMP_InputField inpPlayerName;

    [SerializeField]
    Button btnRock;

    [SerializeField]
    Button btnScissors;

    // TODO - Add paper button
    // TODO - Add reset button
    // TODO - Add game logic
    // Hint: use a number to represent the player's choice and another number to represent the computer's choice
    // Hint: perhaps Rock is 0, Paper is 1, and Scissors is 2. The computer can do this by generating a random number (see line 40 of Lab5.cs)

    void Start()
    {
        // Tells Unity to run OnPlayerNameSubmit when we press Enter (assuming the input field has focus)
        inpPlayerName.onSubmit.AddListener(OnPlayerNameSubmit);

        // Tells Unity what to do when each button is clicked
        btnRock.onClick.AddListener(OnRockClick);
        btnScissors.onClick.AddListener(OnScissorsClick);

        // Make the buttons invisible initially
        btnRock.gameObject.SetActive(false);
        btnScissors.gameObject.SetActive(false);
    }

    void OnRockClick()
    {
        Debug.Log("You played Rock!");
    }

    void OnScissorsClick()
    {
        Debug.Log("You played Scissors!");
    }

    void OnPlayerNameSubmit(string text)
    {
        // Update greeting text and output to the console
        string message = "Welcome, " + text;
        txtWelcome.text = message;
        Debug.Log(message);

        // Makes the buttons visible
        btnRock.gameObject.SetActive(true);
        btnScissors.gameObject.SetActive(true);
    }
}

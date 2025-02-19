using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RockPaperScissors : MonoBehaviour
{
    // SerializedField allows a value to be accessed within the Inspector (so we can drag & drop out button into this script)
    [SerializeField]
    TMP_Text txtWelcome;

    [SerializeField]
    Button btnRock;

    [SerializeField]
    TMP_InputField inpPlayerName;

    // No need to store the player's name directly at the moment. Setting corresponding wigets on-input-submit
    //string playerName = string.Empty;

    void Start()
    {
        // Tells Unity to run the OnClickHandler when we click our button
        btnRock.onClick.AddListener(OnRockClick);
        inpPlayerName.onSubmit.AddListener(OnPlayerNameSubmit);
    }

    void OnRockClick()
    {
        Debug.Log("You played Rock!");
    }

    void OnPlayerNameSubmit(string text)
    {
        string message = "Welcome, " + text;
        txtWelcome.text = message;
        Debug.Log(message);
    }
}

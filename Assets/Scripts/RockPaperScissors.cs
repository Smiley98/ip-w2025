using UnityEngine;
using UnityEngine.UI;

public class RockPaperScissors : MonoBehaviour
{
    // SerializedField allows a value to be accessed within the Inspector (so we can drag & drop out button into this script)
    [SerializeField]
    Button btnRock;

    void Start()
    {
        // Tells Unity to run the OnClickHandler when we click our button
        btnRock.onClick.AddListener(OnClickHandler);
    }

    void OnClickHandler()
    {
        Debug.Log("You played Rock!");
    }
}

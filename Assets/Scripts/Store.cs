using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    [SerializeField]
    TMP_Text itemStatus;

    [SerializeField]
    TMP_Text itemName;

    [SerializeField]
    TMP_Text itemCost;

    [SerializeField]
    TMP_Text itemDescription;

    [SerializeField]
    Button prev;

    [SerializeField]
    Button next;

    [SerializeField]
    Button purchase;

    const int ITEM_COUNT = 5;
    int item = 0;
    float gold = 100.0f;
    bool[] owned = new bool[ITEM_COUNT];

    string[] itemNames = new string[ITEM_COUNT];
    string[] itemDescriptions = new string[ITEM_COUNT];
    float[] itemCosts = new float[ITEM_COUNT];

    void Start()
    {
        itemNames[0] = "Long Sword";
        itemNames[1] = "Long Bow";
        itemNames[2] = "Small Shield";
        itemNames[3] = "Big Shield";
        itemNames[4] = "Dagger";

        itemDescriptions[0] = "Effective for melee-combat.";
        itemDescriptions[1] = "Effective for ranged-combat.";
        itemDescriptions[2] = "Effective for potentially not getting killed.";
        itemDescriptions[3] = "More effective for potentially not getting killed.";
        itemDescriptions[4] = "Very small sword, highly effective at stabbing.";

        itemCosts[0] = 50.0f;
        itemCosts[1] = 75.0f;
        itemCosts[2] = 10.0f;
        itemCosts[3] = 25.0f;
        itemCosts[4] = 100.0f;

        UpdateText(item);
        purchase.onClick.AddListener(Purchase);
        prev.onClick.AddListener(CycleLeft);
        next.onClick.AddListener(CycleRight);
    }

    void UpdateText(int slot)
    {
        itemName.text = itemNames[slot];
        itemCost.text = itemCosts[slot].ToString();
        itemDescription.text = itemDescriptions[slot];
        string status = owned[slot] ? "Owned" : "Unowned";
        itemStatus.text = status;
    }

    void Purchase()
    {
        string name = itemNames[item];
        float cost = itemCosts[item];
        if (cost <= gold && !owned[item])
        {
            gold -= cost;
            owned[item] = true;
            Debug.Log("Purchased " + name);
            Debug.Log("You have " + gold + " left.");
        }
        else
        {
            // TODO - test for owned vs no gold failure, add more information
            Debug.LogError("Not enough gold!");
        }

        UpdateText(item);
    }

    void CycleLeft()
    {
        item--;
        item = Mathf.Max(0, item);
        UpdateText(item);
    }

    void CycleRight()
    {
        item++;
        item = Mathf.Min(item, ITEM_COUNT - 1);
        UpdateText(item);
    }
}

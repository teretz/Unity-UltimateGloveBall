using UnityEngine;

public class UGBApplication : MonoBehaviour
{
    void Start()
    {
        Init();
    }

    void Init()
    {
        // Example: Initialize default player preferences
        PlayerPrefs.SetInt("DefaultLives", 3);
        // Example: Initialize loot tables
        // ... (your loot table initialization code here)
    }
}
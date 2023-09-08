using UnityEngine;

public class PlayerPrefabSwitcher : MonoBehaviour
{
    public GameObject[] playerPrefabs;
    public int currentPrefabIndex = 0;
    public GameManager gameManager;

    void Awake()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    public void SwitchPrefab(int newIndex)
    {
        if(newIndex == -1) // None selected
        {
            return; // Revert to default settings
        }
        Destroy(gameObject);
        GameObject newPlayer = Instantiate(playerPrefabs[newIndex], transform.position, transform.rotation);
        currentPrefabIndex = newIndex;
        gameManager.StartGame();
    }
}
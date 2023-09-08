using UnityEngine;

public class LootGenerator : MonoBehaviour
{
    public GameObject[] lootPrefabs;
    public GameManager gameManager;

    void Awake()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    public void GenerateLoot(Vector3 spawnLocation)
    {
        int randomIndex = Random.Range(0, lootPrefabs.Length);
        GameObject loot = Instantiate(lootPrefabs[randomIndex], spawnLocation, Quaternion.identity);
    }
}
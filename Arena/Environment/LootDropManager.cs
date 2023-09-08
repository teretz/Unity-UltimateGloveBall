using UnityEngine;

public class LootDropManager : MonoBehaviour
{
    public GameObject[] lootPrefabs;
    public GameManager gameManager;

    void Awake()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    public void DropLoot(Vector3 dropLocation)
    {
        int randomIndex = Random.Range(0, lootPrefabs.Length);
        GameObject loot = Instantiate(lootPrefabs[randomIndex], dropLocation, Quaternion.identity);
    }
}
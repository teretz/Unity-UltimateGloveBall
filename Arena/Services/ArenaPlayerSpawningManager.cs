using UnityEngine;

public class ArenaPlayerSpawningManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform[] spawnPoints;
    public GameManager gameManager;

    void Awake()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    public void SpawnPlayer(Vector3 spawnLocation)
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];
        GameObject player = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        gameManager.StartGame();
    }
}
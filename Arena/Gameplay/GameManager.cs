using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform spawnPoint;
    public ArenaPlayerSpawningManager arenaPlayerSpawningManager;
    public PlayerPrefabSwitcher playerPrefabSwitcher;
    public LootGenerator lootGenerator;
    public LootDropManager lootDropManager;
    public Text gameTimerText;
    private float gameTimer = 0f;

    void Awake()
    {
        arenaPlayerSpawningManager = GameObject.FindObjectOfType<ArenaPlayerSpawningManager>();
        playerPrefabSwitcher = GameObject.FindObjectOfType<PlayerPrefabSwitcher>();
        lootGenerator = GameObject.FindObjectOfType<LootGenerator>();
        lootDropManager = GameObject.FindObjectOfType<LootDropManager>();
    }

    public void StartGame()
    {
        arenaPlayerSpawningManager.SpawnPlayer(spawnPoint.position);
        gameTimer = 0f;
    }

    void Update()
    {
        gameTimer += Time.deltaTime;
        gameTimerText.text = "Time: " + gameTimer.ToString("F2");
    }
}
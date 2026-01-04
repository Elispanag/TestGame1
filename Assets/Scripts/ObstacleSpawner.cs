using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform player;

    public float spawnDistance = 100f; // Distance ahead of the player to spawn obstacles
    public float distanceBetweenObstacles = 20f; // Distance between obstacles
    public float sideRange = 5f; // Range on either side to spawn obstacles

    //Latest position z with obstacle spawned
    private float lastSpawnZ = 0f;

    void Start()
    {
        // Find the player transform if not assigned
        if (player == null)
        {
            GameObject p = GameObject.FindGameObjectWithTag("Player");
            if (p != null) player = p.transform;
        }
      
        if (player != null) lastSpawnZ = player.position.z;
    }

    void Update()
    {   
        if (player == null) return;
        if (player.position.z - lastSpawnZ > distanceBetweenObstacles)
        {
            SpawnObstacle();
            //Update the last spawn position
            lastSpawnZ = player.position.z;
        }
        // Adjust spawn rate based on player's z position to increase difficulty
        //Every 500 units, increase spawn rate
        float difficultyBonus = player.position.z / 500f;
        float currentDistance = Mathf.Clamp(20f - difficultyBonus, 8f, 20f);
        distanceBetweenObstacles = currentDistance;
        
    }

    void SpawnObstacle()
    {
        // Randomly choose a position within the side range
        float randomX = Random.Range(-sideRange, sideRange);

        // Set spawn position ahead of the player
        Vector3 spawnPos = new Vector3(randomX, 0, player.position.z + spawnDistance);
        
        if (obstaclePrefab != null)
        {
            Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
        } else
        {
            Debug.LogError("Obstacle Prefab is not assigned in the Inspector.");
        }
    }
}
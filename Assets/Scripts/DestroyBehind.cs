using UnityEngine;

public class DestroyBehind : MonoBehaviour
{
    private Transform playerTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the player by tag
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z > transform.position.z + 10f)
        {
            Destroy(gameObject);
        }
    }
}

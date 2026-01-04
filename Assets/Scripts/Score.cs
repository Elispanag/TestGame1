using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   public Transform player;
   public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        // Score is based on the player's z position without decimal places
        scoreText.text = "SCORE: " + player.position.z.ToString("0");
    }
}

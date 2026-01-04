using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives = 3; // Player starts with 3 lives
    private int maxLives = 3;

    public Image heartFillImage;

    void Start()
    {
        maxLives = lives;
        UpdateHeartsUI();
    }
    public void LoseLife()
    {
        lives--;
        UpdateHeartsUI();

        if (lives <= 0)
        {   //When lives reach 0 restart the scene
           UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
    void UpdateHeartsUI()
    {
       if (heartFillImage != null)
       {
           heartFillImage.fillAmount = (float)lives / maxLives;
       }
    }
}

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public BirdScript birdScript;
    public AudioSource dingSFX;
    public AudioSource backgroundSong;
    public AudioSource gameOverSFX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        backgroundSong.Play();
        birdScript = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if(birdScript.birdIsAlive == true)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
            dingSFX.Play();
        }   
        
    }   
    
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        backgroundSong.Stop();
        gameOverSFX.Play();
        gameOverScreen.SetActive(true);
    }
}

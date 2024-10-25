//Manages game states, scores, etc.//

public class GameManager : MonoBehaviour
{
    public bool isGameOver = false;

    public void EndGame()
    {
        isGameOver = true;
        Debug.Log("Game Over!");
    }
}

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int playerScore;
    private int computerScore;

    public void IncreasePlayerScore()
    {
        playerScore++;
        Debug.Log("Player: " + playerScore);
        ball.ResetPosition();
    }

    public void IncreaseComputerScore()
    {
        computerScore++;
        Debug.Log("Computer: " + computerScore);
        ball.ResetPosition();
    }
}

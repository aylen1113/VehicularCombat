using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public int enemyCount;

    void Update()
    {
        if (enemyCount <= 0)
        {
            Win();
        }

        if (player == null)
        {
            Lose();
        }
    }

    void Win()
    {
        Debug.Log("You Win!");
     
    }

    void Lose()
    {
        Debug.Log("You Lose!");
  
    }
}

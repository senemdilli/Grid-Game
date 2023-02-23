using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalCollision : MonoBehaviour
{
    public void WinGame()
    {
        SceneManager.LoadScene(2);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        WinGame();
    }

}

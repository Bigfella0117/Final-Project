using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    public float enemyCount = 2f;
    public string nextScene;

    void nextLevel()
    {
        if(enemyCount <= 0)
        {
            SceneManager.LoadScene(nextScene);
        }
    }

    void Update()
    {
        nextLevel();
    }
}

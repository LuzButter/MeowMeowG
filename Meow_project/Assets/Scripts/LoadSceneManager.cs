using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager: MonoBehaviour
{
    public int i_LevelToLoad;
    public string s_LevelToLoad;

    public int x_Pos;
    public int y_Pos;

    public bool Use_Name_To_Load;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            LoadScene();
        }
    }
    void LoadScene()
    {
        if (!Use_Name_To_Load)
        {
            SceneManager.LoadScene(i_LevelToLoad);
            PlayerMovement.Player.transform.position =new Vector2 (x_Pos,y_Pos);
        }
        else
        {
            SceneManager.LoadScene(s_LevelToLoad);
            PlayerMovement.Player.transform.position = new Vector2(x_Pos, y_Pos);
        }
    }
}

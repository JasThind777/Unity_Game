using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{

    private int sceneIndex = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level01()
    {

        sceneIndex = 3;

    }

    public void Level02()
    {

        sceneIndex = 4;

    }

    public void Level03()
    {

        sceneIndex = 5;

    }

    public void StartGame()
    {

        SceneManager.LoadScene(sceneIndex);

    }

}

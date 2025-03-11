using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneMove : MonoBehaviour
{
    public void GameSceneCtrl(){
        SceneManager.LoadScene("mjhProject"); //어떤 씬으로 이동할건지
        Debug.Log("mjhProject Scene");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
}

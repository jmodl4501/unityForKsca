using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class  GameScene : MonoBehaviour
{
    [SerializeField] UserController userController;

    
    private void Start() {
    }


    private void Update() {
    }

    public void exit(){
        Debug.Log("exit Event");
        SceneManager.LoadScene("Intro");
    }    
}

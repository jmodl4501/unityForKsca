using UnityEngine;
using UnityEngine.SceneManagement;

public class  GameScene : MonoBehaviour
{
    // [SerializeField] private float gravityValue = -9.81f;

    [SerializeField] UserController userController;

    
    private void Start() {
        
    }
    private void Update() {
        
    }
    
    public void jump(){
        Debug.Log("jump Event");
        userController.jump();
    }

    public void exit(){
        Debug.Log("exit Event");
        SceneManager.LoadScene("Intro");
    }    
}

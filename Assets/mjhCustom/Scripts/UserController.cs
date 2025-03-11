using UnityEngine;
using UnityEngine.SceneManagement;

public class  UserController : MonoBehaviour
{
    [SerializeField] GameObject user;
    [SerializeField] UserController userController;
    private void Start() {
        
    }
    private void Update() {
        
    }
    
    public void jump(){
        userController.jump();
    }
    public void exit(){
        SceneManager.LoadScene("Intro");
    }
}

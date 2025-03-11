using UnityEngine;

public class  GameScene : MonoBehaviour
{
    [SerializeField] private float gravityValue = -9.81f;

    [SerializeField] UserController userController;

    
    private void Start() {
        
    }
    private void Update() {
        
    }
    
    public void jump(){
        userController.jump();
    }

    public void exit(){

    }    
}

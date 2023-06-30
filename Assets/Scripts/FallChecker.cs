using UnityEngine;
using UnityEngine.SceneManagement;
public class FallChecker : MonoBehaviour
{
    public GameObject player;
    public GameObject seeSawPlane;

    private void Update() 
    {
        if(player.transform.position.y < -4 || seeSawPlane.transform.position.y < -4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);         
        }
    }
}

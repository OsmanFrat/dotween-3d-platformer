using System.Collections;
using UnityEngine;

public class LevelComplate : MonoBehaviour
{
    public GameObject lvlCompletePanel;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")    
        {
            lvlCompletePanel.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            StartCoroutine(DelayLittle());
        }
    }

    IEnumerator DelayLittle()
    {   
        yield return new WaitForSeconds(2); 
        Time.timeScale = 0;
    }
}

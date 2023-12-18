using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    private bool enterCollider;
    [SerializeField] private string targetSceneName;
    
    void Start()
    {
        enterCollider = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enterCollider && Input.GetKeyDown(KeyCode.E)) 
        {
            SceneManager.LoadScene(targetSceneName);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            enterCollider = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            enterCollider = false;
        }
    }
}

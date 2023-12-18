using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenegerScene : MonoBehaviour
{
    public string LastLoadedScene;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Village");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rbPlayer;
    [SerializeField] private float speed;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isWalk", false);

        float dirX = Input.GetAxisRaw("Horizontal") * speed;
        if (dirX != 0)
        {
            transform.localScale = new Vector3(-Mathf.Sign(dirX), 1, 1);
            //rbPlayer.isKinematic = false;
        }
        else
        {
            //rbPlayer.isKinematic = true;
        }
        animator.SetBool("isWalk", dirX != 0);
        rbPlayer.velocity = new Vector2(dirX, rbPlayer.velocity.y);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if(GameObject.FindFirstObjectByType<MenegerScene>().LastLoadedScene.Length > 0)
        {
            GameObject teleport = GameObject.Find("TeleportTo" + GameObject.FindFirstObjectByType<MenegerScene>().LastLoadedScene);
            if(teleport != null)
            {
                gameObject.transform.position = teleport.transform.position;
            }
        }
        GameObject.FindFirstObjectByType<MenegerScene>().LastLoadedScene = scene.name;
    }
}

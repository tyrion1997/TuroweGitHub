using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionNPCtoPlayer : MonoBehaviour
{
    public SpriteRenderer sr;
    public Material defaultMat;
    public Material outlineMat;

    public void Start()
    {
        sr.material = defaultMat;
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("Witaj");
            sr.material = outlineMat;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("¯egnaj");
            sr.material = defaultMat;
        }
    }
}

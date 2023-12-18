using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovemantReflex : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Player")]
    [SerializeField] private Transform player;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(player.position.x + 0.3f, this.transform.position.y, this.transform.position.z);
    }
}

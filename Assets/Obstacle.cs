using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(3 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("GameOverScene");
    }
}

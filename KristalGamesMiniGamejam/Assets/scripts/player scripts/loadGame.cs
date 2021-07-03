using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(intro());
    }

    IEnumerator intro()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("game");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Replay", 3);
    }

    void Replay()
    {
        SceneManager.LoadScene(0);
    }
}

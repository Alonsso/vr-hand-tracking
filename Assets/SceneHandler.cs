using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public string nextSceneName;
    public List<Transform> others = new List<Transform>();

    public Transform objective;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in others)
        {
            if (Vector3.Distance(item.position, objective.position) < 0.05)
            {
                others.Remove(item);
            }
        }
        if(others.Capacity == 0){
            SceneManager.LoadScene(nextSceneName);
        }
    }
}

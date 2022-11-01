using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectedBalls : MonoBehaviour
{
    public string nextSceneName;
    public List<GameObject> others = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(others.Capacity == 0){
            SceneManager.LoadScene(nextSceneName);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        others.Remove(other.gameObject);
    }

    public void Siguiente(){
        SceneManager.LoadScene("VrHT2");
    }
}

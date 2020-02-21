using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerminalControl : MonoBehaviour {
    public GameObject door;

    public Transform water;
    public AudioSource waterSound;
    public GameObject particleEffect;
    public Ouch dilet;
    public int terminals = 3;
    // Update is called once per frame
    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;
        particleEffect.SetActive(false);
        
    }
    void Update () {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;
        if (terminals == 0)
        {
            Destroy(door);
            
            if (sceneName == "Water")
            {
                waterSound.Play();
                StartCoroutine(Waterdrain());
                terminals = 1;
            }
            particleEffect.SetActive(true);
        }
        
	}
    IEnumerator Waterdrain()
    {
        //-13.66
        //-6.29
        
        for (float i = -6.29f; i >= -13.66f; i -= 0.1f)
        {
            water.transform.position = new Vector3(water.transform.position.x, i, water.transform.position.z);
            yield return new WaitForSeconds(0.05f);
        }
        
        yield return null;
    }
}

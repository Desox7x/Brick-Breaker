using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    public string LoadLevel;
    public float Loading;
	[ContextMenu("Start Load")]
    public void StartLoading()
    {
        Invoke("CargarNivel", Loading);
    }
    void CargarNivel()
    {
        SceneManager.LoadScene(LoadLevel);
    }
    public bool LastLevel()
    {
        return LoadLevel == "Menu";
    }
}

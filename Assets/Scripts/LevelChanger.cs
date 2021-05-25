using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    private Animator anim;
    private int levelToLoad;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void FadeToLevel(int ltl)
    {
        anim.SetTrigger("fade");
        levelToLoad = ltl;
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}

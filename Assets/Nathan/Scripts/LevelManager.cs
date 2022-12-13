using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public Animator startCurtain, endCurtain;
    public int scoreScene;
    public int scoreSceneNeed;
    public bool goNexwtGame = false;

    public string nextScene;
    public bool switchMiniGame = false;

    public ParticleSystem WinParticule;

    public Animator animator;

    // Start is called before the first frame update
    void ResetComponent()
    {
        scoreScene = 0;
        goNexwtGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreScene == scoreSceneNeed)
        {
            GoToNextScene();
        }
    }

    public void GoToNextScene()
    {
        Instantiate(WinParticule, transform.position, Quaternion.identity);
        switchMiniGame = true;
        animator.SetTrigger("End");
    }

    private void LaunchEndOfScene()
    {
        Debug.Log("coucou");
        ResetComponent();
        SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
    }
    
}

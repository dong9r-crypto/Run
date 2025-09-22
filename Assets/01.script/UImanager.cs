#if UNITY_EDITOR
    using UnityEditor;
#endif
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public AudioSource music;
    
    
    //게임 재시작
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //게임종료
    public void Exit()
    {
#if  UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
Application.Quit();
#endif

        Application.Quit();
    }

    public void TiemScale(int scale)
    {
        //유니티 엔진의 시간
        Time.timeScale = scale;

        switch (scale)
        {
            case 0:
                music.Pause();
                //music.stop는 아예 정지 위에는 일시정지
                break;
            case 1:
                music.Play();
                break;
        }
    }
}

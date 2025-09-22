#if UNITY_EDITOR
    using UnityEditor;
#endif
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public AudioSource music;
    
    
    //���� �����
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //��������
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
        //����Ƽ ������ �ð�
        Time.timeScale = scale;

        switch (scale)
        {
            case 0:
                music.Pause();
                //music.stop�� �ƿ� ���� ������ �Ͻ�����
                break;
            case 1:
                music.Play();
                break;
        }
    }
}

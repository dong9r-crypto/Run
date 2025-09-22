using UnityEngine;

// 발판으로서 필요한 동작을 담은 스크립트
public class Platform : MonoBehaviour
{
    [SerializeField] GameObject[] obstacles; //장애물 오브젝트들
    bool stepped;//플레이어 캐릭터가 밟았는가
    int count;//발판에 장애물이 몇 개 있는지 확인목적,

    private void OnEnable()
    {
        count = 0;//점수 초기화
        
        //발판 상태를 리셋
        stepped = false;
        //장애물의 수만큼 루프
        for (int i = 0; i < obstacles.Length; i++)
        {
            if (Random.Range(0, 3) == 2)
            {
                obstacles[i].SetActive(true);
                count++;
                //count = count + 1; count += 1; ++count;
            }
            else
                obstacles[i].SetActive(false);
        }
    }

    //충돌
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (!stepped && coll.transform.tag == "Player")
        {
            stepped = true;
            int newScore = count + 1;
            GameManager.instance.AddScore(newScore);
        }
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // 싱글톤
    // 어디에서나 접근 할 수 있도록 static(정적)으로 자기자신을 
    // 저장해서 싱글톤이라는 디자인 패턴을 사용해본다.
    public static GameManager instance;
    public Text scoreText;  // 점수를 표시하는 Text 객체를 에디터에서 받아온다.
    public Text StartText;  // 게임 시작 전 3, 2, 1
    int score = 0;  // 점수를 관리한다.

    private void Awake()
    {
        if(instance == null) // 정적으로 자신을 체크한다.
        {   
            instance = this;    // 자기자신을 저장한다.
        }
    }
    void Start()
    {
        StartCoroutine("StartGame");
    }

    IEnumerator StartGame()
    {
        int i = 3;
        while(i > 0)
        {
            StartText.text = i.ToString();

            yield return new WaitForSeconds(1);

            i--;

            if(i == 0)
            {
                StartText.gameObject.SetActive(false);  // UI 감추기
            }
        }
    }

    public void AddScore(int num)
    {
        score += num;   // 점수를 더해준다.
        string v = "Score : " + score;
        scoreText.text = v;    // 텍스트에 반영한다.
    }


}

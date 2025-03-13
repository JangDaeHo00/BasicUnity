using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float Speed = 3;
    public float Delay = 1f;
    public Transform ms1;
    public Transform ms2;
    public GameObject bullet;


    void Start()
    {
        // 한번 함수 호출
        Invoke("CreateBullet", Delay);
    }

    void CreateBullet()
    {
        Instantiate(bullet, ms1.position, Quaternion.identity);
        Instantiate(bullet, ms2.position, Quaternion.identity);

        // 재귀호출
        Invoke("CreateBullet", Delay);
    }

    // 이렇게 써도 반복 or coroutine 사용
    // coroutine이 성능은 더 좋다.


    void Update()
    {
        // 아래 방향으로 움직여라
        transform.Translate(Vector3.down * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}



// Invoke의 의미와 사용 예시
// Invoke는 "호출하다" 또는 "실행하다"는 의미를 가지며, 프로그래밍에서 메서드, 함수, 이벤트 등을 실행할 때 사용됩니다.

// C#에서 Invoke
// C#에서는 주로 델리게이트(delegate) 또는 메서드를 호출할 때 사용됩니다.
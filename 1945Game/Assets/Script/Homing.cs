using UnityEngine;

public class Homing : MonoBehaviour
{
    public GameObject target;   // 플레이어 찾기
    public float Speed = 3f;
    Vector2 dir;
    Vector2 dirNo;

    void Start()
    {
        // 플레이어 태그로 찾기
        //target = GameObject.Find()  // 전체적으로 찾는다
        target = GameObject.FindGameObjectWithTag("Player");

        //A - B : A를 바라보는 벡터 => 플레이어 - 미사일 = 플레이어를 바라보는 벡터
        dir = target.transform.position - transform.position;
        // 방향벡터만 구하기 단위벡터 정규화 노말 1의 크기로 만든다.
        dirNo = dir.normalized;

    }

    void Update()
    {
        // 아예 플레이어를 계속 따라가는 경우
        // A - B : A를 바라보는 벡터 => 플레이어 - 미사일 = 플레이어를 바라보는 벡터
        //dir = target.transform.position - transform.position;
        //// 방향벡터만 구하기 단위벡터 정규화 노말 1의 크기로 만든다.
        //dirNo = dir.normalized;
        transform.Translate(dirNo * Speed * Time.deltaTime);

        // 계속 따라오게 하는 유니티 코드.
        //transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}


using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 0.45f;
    public GameObject explosion;

    void Start()
    {
        
    }

    void Update()
    {
        // Y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    private void OnBecameInvisible()
    {
        // 미사일이 화면 밖으로 나갔으면
        // 미사일을 지운다
        Destroy(gameObject);    // 소문자 자기자신 즉 여기선 무기(bullet)을 지운다.

        // GameObject // 클래스 타입!
    }

    // 2D 충돌 트리거이벤트
    // Enter : 처음 들어올 때
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 미사일과 적이 부딫혔다
        //if(collision.gameObject.tag == "Enemy")
        if (collision.gameObject.CompareTag("Enemy"))   // 이게 더 안전.
        {
            // 폭발 이펙트 생성
            Instantiate(explosion, transform.position, Quaternion.identity);

            // 적 지우기
            Destroy(collision.gameObject);  // Enemy -> collision.gameObject

            // 총알 지우기 자기자신
            Destroy(gameObject);
            
        }
    }




}

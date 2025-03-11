using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;   // 미사일 프리팹 가져올 변수, GameObject : 최상위 클래스
    void Start()
    {
        // InvokeRepeating(함수이름, 초기지연시간, 지연할 시간);
        InvokeRepeating("Shoot", 0.5f, 0.5f);   // 0.5초마다 Shoot을 플레이한다.
    }

     void Shoot()
    {
        // 미사일 프리팹, 런쳐포지션, 방향값 안줌 // 중요!!!!!!!!!!
        Instantiate(bullet, transform.position, Quaternion.identity);   // 자주 쓴다!!!!!!!

        // 사운드 사용해보기 사운드매니저에서 총 사운드 바로 실행함수 호출 싱글톤 사용
        SoundManager.instance.PlayBulletSound();
    }
    void Update()
    {
        
    }
}

using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // 몬스터 가지고 오기
    public GameObject enemy;
    public GameObject normalenemy1;
    public GameObject normalenemy2;
    public GameObject boss;

    // 적을 생성하는 함수
    void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f);  // 적이 나타날 X좌표를 랜덤으로 생성하기
        
        // 적을 생성한다. randomX 랜덤한 X값
        Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
    }

    void SpawnNormalEnemy1()
    {
        float randomX = Random.Range(-2.5f, 2.5f);
        Instantiate(normalenemy1, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);

    }
    void SpawnNormalEnemy2()
    {
        float randomX = Random.Range(-3f, 3f);
        Instantiate(normalenemy2, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);

    }
    void SpawnBoss()
    {
        Instantiate(boss, new Vector3(0f, transform.position.y, 0f), Quaternion.identity);

    }

    void Start()
    {
        // SpawnEnemy   1   0.5f
        InvokeRepeating("SpawnEnemy", 1, 1f);
        InvokeRepeating("SpawnNormalEnemy1", 10, 2.5f);
        InvokeRepeating("SpawnNormalEnemy2", 15, 6f);
        InvokeRepeating("SpawnBoss", 30, 30f);
    }

    void Update()
    {
        
    }
}

using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // 싱글론
    public static SoundManager instance;    // 자기 자신을 변수로 담기

    AudioSource myAudio;    // AudioSource 컴포넌트를 변수로 담는다.

    public AudioClip SoundBullet;    // 총알 소리
    public AudioClip soundDie;      // 죽는 사운드

    private void Awake()
    {
        if(SoundManager.instance == null)   // 인스턴스 있는지 검사
        {
            SoundManager.instance = this;   // 자기 자신을 담는다.
        }
    }

    void Start()
    {
        myAudio = GetComponent<AudioSource>();  // AudioSource 컴포넌트 가져오기
    }


    public void PlayBulletSound()
    {
        myAudio.PlayOneShot(SoundBullet);
    }
    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie);
    }
}

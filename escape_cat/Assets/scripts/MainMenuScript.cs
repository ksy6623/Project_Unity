using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenuScript : MonoBehaviour
{
    public GameObject settingsPanel;
    public VideoPlayer videoPlayer;  // VideoPlayer를 연결할 필드
    public string gameSceneName = "GameScene";  // 게임 씬 이름

    private bool isVideoPlaying = false;  // 영상이 재생 중인지 확인

    // 게임 시작 버튼
    public void StartGame()
    {
        // VideoPlayer에 재생 완료 이벤트 등록
        videoPlayer.loopPointReached += OnVideoFinished; 
        videoPlayer.Play();  // 영상을 재생
        isVideoPlaying = true;  // 영상이 재생 중임을 표시
    }

    // 영상 재생이 끝났을 때 호출되는 함수
    void OnVideoFinished(VideoPlayer vp)
    {
        LoadGameScene();
    }

    // 스페이스바 입력으로 영상을 스킵하고 바로 게임 씬으로 이동
    void Update()
    {
        if (isVideoPlaying && Input.GetKeyDown(KeyCode.Space))
        {
            videoPlayer.Stop();  // 영상 중지
            LoadGameScene();  // 게임 씬 로드
        }
    }

    // 게임 씬 로드 함수
    void LoadGameScene()
    {
        isVideoPlaying = false;  // 영상이 종료됨
        SceneManager.LoadScene(gameSceneName);  // 게임 씬 로드
    }

    // 설정 버튼
    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false); // 설정 패널을 비활성화
    }

    // 종료 버튼
    public void QuitGame()
    {
        Application.Quit(); // 게임 종료
    }
}

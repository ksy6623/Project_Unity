using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public GameObject settingsPanel;  // 설정 패널
    public Button settingsButton;     // 설정 버튼
    public Button closeButton;        // 닫기 버튼

    void Start()
    {
        // 버튼 클릭 이벤트에 메서드 연결
        settingsButton.onClick.AddListener(OpenSettings);
        closeButton.onClick.AddListener(CloseSettings);
        
        // 설정 패널을 비활성화 상태로 시작
        settingsPanel.SetActive(false);
    }

    // 설정 패널 열기 함수
    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    // 설정 패널 닫기 함수
    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }
}

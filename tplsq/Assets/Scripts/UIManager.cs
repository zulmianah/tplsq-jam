using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject MainPanel, MusicConfiguration, MonitorAdjustment, KeyConfiguration;
    public void MusicConfigurationToMainPanel()
    {
        MusicConfiguration.gameObject.SetActive(false);
        MainPanel.gameObject.SetActive(true);
    }
    public void MonitorAdjustmentToMainPanel()
    {
        MonitorAdjustment.gameObject.SetActive(false);
        MainPanel.gameObject.SetActive(true);
    }
    public void KeyConfigurationToMainPanel()
    {
        KeyConfiguration.gameObject.gameObject.SetActive(false);
        MainPanel.gameObject.SetActive(true);
    }
    public void MainPanelToMusicConfiguration()
    {
        MainPanel.gameObject.SetActive(false);
        MusicConfiguration.gameObject.SetActive(true);
    }
    public void MainPanelToKeyConfiguration()
    {
        MainPanel.gameObject.SetActive(false);
        KeyConfiguration.gameObject.SetActive(true);
    }
    public void MainPanelToMonitorAdjustment()
    {
        MainPanel.gameObject.SetActive(false);
        MonitorAdjustment.gameObject.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void exitGame()
    {

    }
}

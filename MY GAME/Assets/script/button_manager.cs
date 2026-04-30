using UnityEngine;
using UnityEngine.SceneManagement;

public class button_manager : MonoBehaviour
{

    public GameObject reloadPanel;

    public void OpenReload()
    {
        if (reloadPanel != null)
        {
            reloadPanel.SetActive(true);
        }
    }

    public void CloseReload()
    {
        if (reloadPanel != null)
        {
            reloadPanel.SetActive(false);
        }
    }

}

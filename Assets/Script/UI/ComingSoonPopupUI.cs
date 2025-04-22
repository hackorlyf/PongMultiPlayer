using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComingSoonPopupUI : MonoBehaviour
{
    [SerializeField] private Button _closeBtn;
    [SerializeField] private Button _BgBtn;
    // Start is called before the first frame update
    void Start()
    {
        Hide();
        _BgBtn.onClick.AddListener(Hide);
        _closeBtn.onClick.AddListener(Hide);
        GameEvents.OnMultiplayerBtnClicked += Show;
    }

    // Update is called once per frame
    void OnDestroy()
    {
        // _BgBtn.RemoveAllListeners();
        // _closeBtn.RemoveAllListeners();
        GameEvents.OnMultiplayerBtnClicked -= Show;
    }

    private void Show(){
        gameObject.SetActive(true);
    }

    private void Hide(){
        gameObject.SetActive(false);
    }
}

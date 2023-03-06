using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueManager : MonoBehaviour
{
    [SerializeField] public int _CurrentClues;
    [SerializeField] private TextMeshProUGUI _ClueText;
    [SerializeField] private GameObject _TextParent;

    [SerializeField] private GameObject _KillerUIPanel;
    [SerializeField] private GameObject _KillerPerson;

    [SerializeField] private GameObject _FindKillerText;

    private void Update()
    {
        if(_CurrentClues >= 5)
        {
            ActivateUI();
        }
    }

    public void AddToClues(int clueamountincrease)
    {
        _CurrentClues += clueamountincrease;
        UpdateText();
    }

    public void UpdateText()
    {
        _ClueText.SetText(_CurrentClues.ToString() + " / 5");
    }

    public void ActivateUI()
    {
        _KillerUIPanel.SetActive(true);
        _KillerPerson.SetActive(true);

        // Lock cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        _CurrentClues = 0;

        Time.timeScale = 0.0001f;
    }

    public void DeactivateUI()
    {
        _KillerUIPanel.SetActive(false);

        // Lock cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        _TextParent.SetActive(false);

        _FindKillerText.SetActive(true);

        Time.timeScale = 1f;
    }
}

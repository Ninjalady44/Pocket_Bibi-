/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: DialogueManager.cs
 * Date Created: March 25 2026
 * Created By: Richard Als
 * Description: 
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: March 25 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace PocketBibi
{
    public class DialogueManager : MonoBehaviour
    {
        #region Singleton

        private static DialogueManager _instance = null;
        public static DialogueManager Instance => _instance;

        #endregion

        #region Private Variables/Fields Exposed to Inspector for Editing

        [SerializeField] private GameData _gameConfig = null;
        [SerializeField] private GameObject _chatBox = null;
        [SerializeField] private TextMeshProUGUI _textBox = null;

        #endregion

        #region Private Variables/Fields used in this Class Only

        private TextAsset _bibiTextSheet;
        private TextAsset _menuUITextSheet;
        private Dictionary<string, string> _bibiText;
        private Dictionary<string, string> _menuUIText;
        private Language _eLanguage;
        private TextSpeed _eTextSpeed;
        private Coroutine _displayTextCoroutine;

        #endregion

        #region Private Initialization Functions/Methods

        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(this.gameObject);
            }

            _instance = this;
        }

        #endregion

        #region Private Functions/Methods

        private void LoadText(TextAsset textFile, Dictionary<string, string> dictionary)
        {
            string[] data = textFile.text.Split(new char[] { '\n' });

            for (int i = 1; i < data.Length - 1; i++)
            {
                string[] row = data[i].Split(new char[] { ',' });
                dictionary.Add(row[0], row[(int)_eLanguage]);
            }
        }

        #endregion

        #region Public Functions/Methods

        public void SetLanguage()
        {
            Resources.Load<TextAsset>("TextSpreadSheets/");
        }

        public void ShowTextBox(string key)
        {
            _chatBox.SetActive(true);

            if (_eTextSpeed == TextSpeed.Instant)
            {
                _textBox.text = _bibiText[key];
            }
            else
            {
                _displayTextCoroutine = StartCoroutine(DisplayText(key));
            }
        }

        #endregion

        private IEnumerator DisplayText(string key)
        {
            for (int i = 0; i < _bibiText.Count; i++)
            {
                _textBox.text += _bibiText[key][i];
                yield return new WaitForSeconds(_gameConfig.TextSpeed[(int)_eTextSpeed]); 
            }
        }
    }
}
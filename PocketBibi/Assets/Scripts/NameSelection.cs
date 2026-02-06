/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: NameSelection.cs
 * Date Created: February 4 2026
 * Created By: Richard Als
 * Description: 
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: February 4 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using TMPro;
using UnityEngine;

namespace PocketBibi
{
    public class NameSelection : MonoBehaviour
    {
        #region Private Variables/Fields Exposed to Inspector for Editing

        [SerializeField] private TMP_InputField _nameInputField = null;
        [SerializeField] private GameObject _confirmButton = null;

        #endregion

        #region Private Functions/Methods

        private void OnEnable()
        {
            _confirmButton.SetActive(false);
        }

        #endregion

        #region Public Functions/Methods for use with Buttons

        public void OnNameInputChanged()
        {
            if(_nameInputField.text != "")
            {
                _confirmButton.SetActive(true);
            }
            else
            {
                _confirmButton.SetActive(false);
            }
        }

        #endregion
    }
}

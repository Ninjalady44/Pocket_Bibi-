/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: GameManager.cs
 * Date Created: March 15 2026
 * Created By: Richard Als
 * Description: 
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: March 15 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using System;
using UnityEngine;

namespace PocketBibi
{
    public class GameManager : MonoBehaviour
    {
        #region Singleton

        private static GameManager _instance = null;
        public static GameManager Instance => _instance;

        #endregion

        #region Private Variables/Fields used in this Class Only

        DateTime _currentDateTime;

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

        private void Start()
        {
            _currentDateTime = DateTime.Now;
            //Debug.Log(_currentDateTime.Minute);
        }

        #endregion
    }
}


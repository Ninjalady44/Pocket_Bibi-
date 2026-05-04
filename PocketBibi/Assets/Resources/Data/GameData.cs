/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: GameData.cs
 * Date Created: January 30 2026
 * Created By: Richard Als
 * Description: ScriptableObject to hold default game information.
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: January 30 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using UnityEngine;

namespace PocketBibi
{
    [CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData")]
    public class GameData : ScriptableObject
    {
        #region Private Variables/Fields Exposed to Inspector for Editing

        [SerializeField, Min(1)] private float _splashScreenTimer = 1;
        [SerializeField] private float[] _textSpeed;

        #endregion

        #region Public Getters/Accessors

        public float SplashScreenTimer => _splashScreenTimer;
        public float[] TextSpeed => _textSpeed;

        #endregion
    }
}



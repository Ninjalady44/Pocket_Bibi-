/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: HatchEvent.cs
 * Date Created: February 06 2026
 * Created By: Richard Als
 * Description: Calls the event after the egg hatching animation
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: February 06 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using UnityEngine;

namespace PocketBibi
{
    public class HatchEvent : MonoBehaviour
    {
        #region Public Functions/Methods

        public void AnimationFinished()
        {
            Actions.evolve?.Invoke();
        }

        #endregion
    }
}
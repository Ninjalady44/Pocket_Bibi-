/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: GameScreen.cs
 * Date Created: February 06 2026
 * Created By: Richard Als
 * Description: 
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: February 06 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using System;
using UnityEngine;

namespace PocketBibi
{
    public class FinishFadingScreen : MonoBehaviour
    {
        public void FinishedFading()
        {
            Actions.evolveScreenFinished?.Invoke();
        }
    }
}
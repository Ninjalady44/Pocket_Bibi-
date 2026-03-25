/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: BibiData.cs
 * Date Created: February 4 2026
 * Created By: Richard Als
 * Description: ScriptableObject to hold default Bibi information.
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: March 25 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using UnityEngine;

namespace PocketBibi
{
    [CreateAssetMenu(fileName = "BibiData", menuName = "ScriptableObjects/BibiData")]
    public class BibiData : ScriptableObject
    {
        [SerializeField] private EvolutionState _eEvolutionState;
        [SerializeField] private Sprite _bibiSprite = null;
        [SerializeField] private RuntimeAnimatorController _animController = null;
        [SerializeField] private BibiData[] _bibiEvolutionsConfig = null;

        public EvolutionState eEvolutionState => _eEvolutionState;
        public Sprite BibiSprite => _bibiSprite;
        public RuntimeAnimatorController AnimController => _animController;
        public BibiData[] BibiEvolutionsConfig => _bibiEvolutionsConfig;
    }
}
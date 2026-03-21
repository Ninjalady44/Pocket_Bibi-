/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: Bibi.cs
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
    public class Bibi : MonoBehaviour
    {
        #region Private Variables/Fields Exposed to Inspector for Editing

        [SerializeField] private SpriteRenderer _spriteRenderer = null;
        [SerializeField] private Animator _animator = null;

        #endregion

        #region Private Variables/Fields used in this Class Only

        private BibiData _currentBibiConfig = null;
        private string _name;
        private int _age;
        private int _missedCareAmount;
        private int _happiness;
        private int _currency;
        private int _weight;
        private int _hungerLevel;
        private DateTime _dateOfBirth;

        #endregion

        #region Public Getters/Accessors

        public string Name => _name;
        public int Age => _age;
        public int Happiness => _happiness;
        public int Currency => _currency;
        public int Weight => _weight;
        public int HungerLevel => _hungerLevel;
        public DateTime DateOfBirth => _dateOfBirth;
        public Sprite BibiSprite => _currentBibiConfig.BibiSprite;

        #endregion

        #region Private Functions/Methods

        private void OnEnable()
        {
            Actions.evolve += EvolveBibi;
        }

        private void OnDisable()
        {
            Actions.evolve -= EvolveBibi;
        }

        #endregion

        #region Public Functions/Methods

        public void BibiInit(BibiData _selectedBibiConfig, string name)
        {
            _currentBibiConfig = _selectedBibiConfig;
            _spriteRenderer.sprite = _currentBibiConfig.BibiSprite;
            _animator.runtimeAnimatorController = _currentBibiConfig.AnimController;
            _name = name;
            _dateOfBirth = DateTime.Now;
        }

        public void EvolveBibi()
        {
            if (_currentBibiConfig.eEvolutionState == EvolutionState.EGG)
            {
                _currentBibiConfig = _currentBibiConfig.BibiEvolutionsConfig[0];
                _animator.runtimeAnimatorController = _currentBibiConfig.AnimController;
                _spriteRenderer.sprite = _currentBibiConfig.BibiSprite;
            }
            else
            {

            }
        }

        #endregion
    }
}

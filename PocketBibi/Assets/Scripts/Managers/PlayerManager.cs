/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: PlayerManager.cs
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

using UnityEngine;

namespace PocketBibi
{
    public class PlayerManager : MonoBehaviour
    {
        #region Singleton
        private static PlayerManager _instance = null;
        public static PlayerManager Instance => _instance;
        #endregion

        #region Private Variables/Fields Exposed to Inspector for Editing

        [SerializeField] private BibiData[] _eggs = null;
        [SerializeField] private Bibi _bibiPrefab = null;
        [SerializeField] private Inventory _inventory = null;

        #endregion

        #region Private Variables/Fields used in this Class Only

        private Bibi _bibi;

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

        #region Public Getters/Accessors

        public Bibi PlayerBibi => _bibi;
        public BibiData[] Eggs => _eggs;
        public Inventory Inventory => _inventory;

        #endregion

        #region Public Functions/Methods
        
        public void SpawnBibi()
        {
            _bibi = Instantiate(_bibiPrefab, transform);
            _bibi.gameObject.SetActive(false);
        }

        #endregion
    }
}

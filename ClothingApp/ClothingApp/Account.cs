using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingApp
{
    class UserAccount
    {
        #region Properties
        /// <summary>
        /// User account properties
        /// </summary>

        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Payment { get; set; }
        
        /// <summary>
        /// Item Properties
        /// </summary>

        public string ClothingType { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Quantity { get; set; }

        #endregion
    }
}

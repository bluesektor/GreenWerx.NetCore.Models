using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenWerx.NetCore.Models
{
    public class Item : Node, INode
    {
        public Item() : base()
        {
        }

        public string CategoryUUID { get; set; }

        /// <summary>
        /// New, used
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// This the price paid by the store/product owner.
        /// If the TotalPrice is less than this, or a defined percentage above
        /// then we need an override to sell at a loss or reduced profit.
        /// </summary>
        public decimal Cost { get; set; }

        public bool Custom { get; set; }

        public string DepartmentUUID { get; set; }

        public string Description { get; set; }

        /// <summary>
        ///        Discount for the product as a percentage.
        /// When updating these records:
        ///   If you specify Discount without specifying price, the price is adjusted to accommodate the new Discount value,
        ///   and the UnitPrice is held constant.
        ///   If you specify both Discount and Quantity, you must also specify either TotalPrice or UnitPrice so the system knows which one to automatically adjust.
        /// </summary>
        public float Discount { get; set; }

        public DateTime? Expires { get; set; }

        public string GroupUUID { get; set; }

        //Manufacturer
        public string ManufacturerUUID { get; set; }

        //Account
        public string ManufacturerUUIDType { get; set; }

        /// <summary>
        /// Number to apply the type
        /// </summary>
        public float MarkUp { get; set; }

        /// <summary>
        /// percent, numeric, multiplier, function/formula (would have to figure this out first).
        /// </summary>
        public string MarkUpType { get; set; }

        /// <summary>
        /// This is the price on display for the customer
        /// </summary>
        ///
        public decimal Price { get; set; }

        public string Quality { get; set; }

        public float Rating { get; set; }
        public string SerialNumber { get; set; }

        //StringLength(50)]
        public string SKU { get; set; }

        //reserved for custom tracking.
        public string SystemUUID { get; set; }

        //how many units were in the product
        public float UnitsInProduct { get; set; }

        //Download,access,trade, jars etc..
        public string UnitType { get; set; }

        public string UOMUUID { get; set; }

        /// <summary>
        /// Set to true if the product is virtual
        /// </summary
        //[JsonConverter(typeof(BoolConverter))]
        public bool Virtual { get; set; }

        /// <summary>
        /// This is weight diplayed for the customer.
        /// Does NOT include packaging weight
        /// if UnitWeight and sale weight differ then you need to do a transfer from to
        /// </summary>
        //[DefaultValue(0)]
        public float Weight { get; set; }

        //[NotMapped]
        public string WeightUOM { get; set; }
    }
}

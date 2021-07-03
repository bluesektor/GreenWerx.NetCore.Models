using System;
using System.Collections;

namespace GreenWerx.NetCore.Models
{
    public class Node : INode
    {
        public Node()
        {
            if (string.IsNullOrWhiteSpace(this.UUID))
                this.UUID = Guid.NewGuid().ToString("N");
            this.UUIDType = string.Empty;
            this.UUParentID = string.Empty;
            this.UUParentIDType = string.Empty;
            this.Name = string.Empty;
            this.Status = string.Empty;
            this.AccountUUID = string.Empty;
            this.Active = true;
            this.Deleted = false;
            this.Private = true;
            this.SortOrder = 0;
            this.CreatedBy = string.Empty;
            this.DateCreated = DateTime.MinValue;
            this.RoleWeight = 1;
            this.RoleOperation = ">=";
            this.Image = "";
        }

        public string AccountUUID { get; set; }

        //[JsonConverter(typeof(BoolConverter))]
        public bool Active { get; set; }

        public string CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        //[JsonConverter(typeof(BoolConverter))]
        public bool Deleted { get; set; }

        public string GUUID { get; set; }

        public string GuuidType { get; set; }

        public string Image { get; set; }

      
        public string Name { get; set; }

        //[JsonConverter(typeof(IntConverter))]
        public int NSFW { get; set; }

        //[JsonConverter(typeof(BoolConverter))]
        public bool Private { get; set; }

        public string RoleOperation { get; set; }

        public int RoleWeight { get; set; }

        // Use ToSafeString(true)?.ToUpper();
        //[NotMapped]
        public string SafeName { get; set; }

        public int SortOrder { get; set; }


        public string Status { get; set; }

        // these are honeypot fields, not mapped to any table fields.
        //[NotMapped]
        public DateTime SubmitDate { get; set; }

        //[NotMapped]
        public string SubmitValue { get; set; }



        
        //[ExplicitKey]
        //  [Dapper.Contrib.Extensions.Key]
        //[Key]
        public string UUID { get; set; }

        /// <summary>
        /// Defines the type of SettingUUID used (guid, hash.<algo> )..
        /// </summary>
        public string UUIDType { get; set; }

        public string UUParentID { get; set; }

        public string UUParentIDType { get; set; }
    }

    public class NodeCompare : IEqualityComparer
    {
        private readonly Func<Node, object> _funcDistinct;

        public NodeCompare(Func<Node, object> funcDistinct)
        {
            this._funcDistinct = funcDistinct;
        }

        public new bool Equals(object x, object y)
        {
            return _funcDistinct((Node)x).Equals(_funcDistinct((Node)y));
        }

        public int GetHashCode(object obj)
        {
            return this._funcDistinct((Node)obj).GetHashCode();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenWerx.NetCore.Models
{
    public interface INode
    {
        string AccountUUID { get; set; }
        bool Active { get; set; }
        string CreatedBy { get; set; }
        DateTime DateCreated { get; set; }
        bool Deleted { get; set; }
        string GUUID { get; set; }
        string GuuidType { get; set; }
        string Image { get; set; }
        string Name { get; set; }
        int NSFW { get; set; }
        bool Private { get; set; }
        string RoleOperation { get; set; }
        int RoleWeight { get; set; }
        int SortOrder { get; set; }
        string Status { get; set; }

        DateTime SubmitDate { get; set; }

        string SubmitValue { get; set; }

        //  [ExplicitKey]
        //   [Dapper.Contrib.Extensions.Key]
        // [Key]
        string UUID { get; set; }

        /// <summary>
        /// Defines the type of SettingUUID used (guid, hash.<algo> )..
        /// </summary>
        string UUIDType { get; set; }

        string UUParentID { get; set; }
        string UUParentIDType { get; set; }
    }
}

using System.Runtime.Serialization;

namespace ItemBE
{

    /// <summary>
    /// Item Information
    /// </summary>
    [DataContract]
    public class ItemInfo
    {

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Manufacturer { get; set; }
        [DataMember]
        public decimal Cost { get; set; }
        [DataMember]
        public int TypeId { get; set; }
        [DataMember]
        public int SubTypeId { get; set; }
    }


    /// <summary>
    /// Item Type
    /// </summary>
    [DataContract]
    public class ItemType
    {
        [DataMember]
        public int TypeId { get; set; }
        [DataMember]
        public string Type { get; set; }

        public ItemType(int id, string type)
        {

            TypeId = id;
            Type = type;
        }
    }

    /// <summary>
    /// Item Sub Type
    /// </summary>
    [DataContract]
    public class ItemSubType
    {
        [DataMember]
        public int SubTypeId { get; set; }
        [DataMember]
        public int TypeId { get; set; }
        [DataMember]
        public string SubType { get; set; }
        public ItemSubType(int id, int typeId, string subType)
        {

            SubTypeId = id;
            TypeId = typeId;
            SubType = subType;
        }

    }

    /// <summary>
    /// Item DTO
    /// </summary>
    /// <seealso cref="ItemBE.ItemInfo" />
    [DataContract]
    public class ItemInfoItemDTO : ItemInfo
    {
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string SubType { get; set; }
    }
}

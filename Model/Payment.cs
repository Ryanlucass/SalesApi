using System;

namespace ApiDynamonDb.Model
{
    public class Payment
    {  
        public Type TypeEnum { get; set; }
        public string Type
        {
            get
            {
                return TypeEnum.ToString();
            }
            set
            {
                if(Enum.TryParse(value, out Type type))
                {
                    TypeEnum = type;
                }
                else { throw new TypeAccessException(value); }
            }
        }
        public string Name { get; set; }
    }

}

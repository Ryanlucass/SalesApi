using System.Collections.Generic;

namespace ApiDynamonDb.Model
{
    public class TechVenda
    {
        public int Id { get; set; }
        public List<Itens> Description { get; set; }
        public decimal Value { get; set; }
        public Payment Payment { get; set; }
    }

}

using System;

namespace ApiDynamonDb.Exceptions
{
    public class TypePaymentExeption : Exception
    {
        public TypePaymentExeption(string code) : base($"Erro do tipo pagamento: {code}")
        {

        }

    }
}

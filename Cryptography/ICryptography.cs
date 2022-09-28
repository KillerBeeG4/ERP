using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Cryptography
{
    internal interface ICryptography
    {
        public enum CryptographyType
        {
            TRANSP,
            SUB
        }

        public static ICryptography GetFor(CryptographyType type)
        {
            switch(type)
            {
                case CryptographyType.TRANSP:
                    return new TranspCryptograhy();
                case CryptographyType.SUB:
                    return new SubCryptography();
            }
            return null;
        }

        public string crypt(string input);

        public string decrpyt(string input);
    }
}

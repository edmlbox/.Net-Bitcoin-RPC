using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.Enums
{
    class EnumConverter
    {
        public static string GetSigHashType(SigHashType hashType)
        {
            switch (hashType)
            {
                case SigHashType.ALL:
                    {
                        return "ALL";
                    }
                case SigHashType.NONE:
                    {
                        return "NONE";
                    }
                case SigHashType.SINGLE:
                    {
                        return "SINGLE";
                    }
                case SigHashType.ALL_ANYONECANPAY:
                    {
                        return "ALL|ANYONECANPAY";
                    }
                case SigHashType.NONE_ANYONECANPAY:
                    {
                        return "NONE|ANYONECANPAY";
                    }
                case SigHashType.SINGLE_ANYONECANPAY:
                    {
                        return "SINGLE|ANYONECANPAY";
                    }
                default:
                    {
                        return null;
                    }
            }


        }
        public static string ConvertChangeType(ChangeType changeType)
        {
            switch (changeType)
            {
                case ChangeType.legacy:
                    {
                        return "legacy";
                    }
                case ChangeType.bech32:
                    {
                        return "bech32";
                    }
                case ChangeType.p2sh_segwit:
                    {
                        return "p2sh-segwit";
                    }
            }

            return null;
        }
        //Have to do something about this!!!
        public static string ConvertChangeType(AddressType addressType)
        {
            switch (addressType)
            {
                case AddressType.legacy:
                    {
                        return "legacy";
                    }
                case AddressType.bech32:
                    {
                        return "bech32";
                    }
                case AddressType.p2sh_segwit:
                    {
                        return "p2sh-segwit";
                    }
            }

            return null;
        }

        //Converts enum to string with slash.

        public static string ConvertMutable(Mutable mutable)
        {
            switch (mutable)
            {
                case Mutable.coinbaseAppend:
                    {
                        return "coinbase/append";
                    }
                case Mutable.timeDecrement:
                    {
                        return "time/decrement";
                    }
                case Mutable.timeIncrement:
                    {
                        return "time/increment";
                    }
                case Mutable.versionForce:
                    {
                        return "version/force";
                    }
                case Mutable.versionReduce:
                    {
                        return "version/reduce";
                    }
                case Mutable.prevblock:
                    {
                        return "prevblock";
                    }
                case Mutable.transactions:
                    {
                        return "transactions";
                    }
                case Mutable.time:
                    {
                        return "time";
                    }
                case Mutable.generation:
                    {
                        return "generation";
                    }
                case Mutable.coinbase:
                    {
                        return "coinbase";
                    }
            }

            return null;
        }


    }

}

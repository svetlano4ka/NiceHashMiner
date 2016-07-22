﻿using System;
using System.Collections.Generic;
using System.Text;
using NiceHashMiner.Enums;

namespace NiceHashMiner
{
    /// <summary>
    /// AlgorithmNiceHashNames class is just a data container for mapping NiceHash JSON API names to algo type
    /// </summary>
    public static class AlgorithmNiceHashNames
    {
        readonly static private Dictionary<AlgorithmType, string> _names = new Dictionary<AlgorithmType, string>()
        {
            { AlgorithmType.Scrypt , "scrypt" },
            { AlgorithmType.SHA256 , "sha256" },
            { AlgorithmType.ScryptNf , "scryptnf" },
            { AlgorithmType.X11 , "x11" },
            { AlgorithmType.X13 , "x13" },
            { AlgorithmType.Keccak , "keccak" },
            { AlgorithmType.X15 , "x15" },
            { AlgorithmType.Nist5 , "nist5" },
            { AlgorithmType.NeoScrypt , "neoscrypt" },
            { AlgorithmType.Lyra2RE , "lyra2re" },
            { AlgorithmType.WhirlpoolX , "whirlpoolx" },
            { AlgorithmType.Qubit , "qubit" },
            { AlgorithmType.Quark , "quark" },
            { AlgorithmType.Axiom , "axiom" },
            { AlgorithmType.Lyra2REv2 , "lyra2rev2" },
            { AlgorithmType.ScryptJaneNf16 , "scryptjanenf16" },
            { AlgorithmType.Blake256r8 , "blake256r8" },
            { AlgorithmType.Blake256r14 , "blake256r14" },
            { AlgorithmType.Blake256r8vnl , "blake256r8vnl" },
            { AlgorithmType.Hodl , "hodl" },
            { AlgorithmType.DaggerHashimoto , "daggerhashimoto" },
            { AlgorithmType.Decred , "decred" },
            // etherum is not documented, BUT is exists in API
            { AlgorithmType.Ethereum , "ethereum" },
        };

        public static string GetName(AlgorithmType type) { return _names[type]; }
    }
}

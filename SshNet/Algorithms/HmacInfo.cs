﻿using System;
using System.Security.Cryptography;

namespace SshNet.Algorithms
{
    public class HmacInfo
    {
        public HmacInfo(KeyedHashAlgorithm algorithm, int keySize)
        {
            KeySize = keySize;
            Hmac = key => new HmacAlgorithm(algorithm, keySize, key);
        }

        public int KeySize { get; private set; }

        public Func<byte[], HmacAlgorithm> Hmac { get; private set; }
    }
}
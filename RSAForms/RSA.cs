using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RSAForms
{
    
    public class RSA
    {
        public BigInteger encryption { get; }
        public BigInteger decryptedMsg { get; }
        public BigInteger p { get; }
        public BigInteger d { get; }
        public BigInteger q { get; }
        public BigInteger φn { get; }
        public KeyStruct publicKey { get; set; } = new KeyStruct();
        public KeyStruct privateKey { get; set; } = new KeyStruct();

        // Just a sample run through
        public RSA(BigInteger msg)
        {
            // Step 1 - choose a 'p' and 'q'
            BigInteger p = 635939;
            BigInteger q = 200443;

            // Step 2 - create 'n' and 'e'
            this.publicKey.N = p * q;
            BigInteger φn = (p - 1) * (q - 1);
            this.publicKey.Key1 = FindE(φn);

            // Step 4 - solve for d by using Extended Euclidean Algorithm
            BigInteger d = ExtendedEuclidean(this.publicKey.Key1, φn);
            this.privateKey.N = p * q;
            this.privateKey.Key1 = d;

            // Step 5 - encrypt the message using modular exponentiation
            this.encryption = ModularExponentation(msg, this.publicKey.Key1, this.publicKey.N);

            // Step 6 - decrypt the message using modular exponentiation
            BigInteger msg_recieved = ModularExponentation(encryption, d, this.privateKey.N);
        }

        // This constructor is used for Alice and Bob run through
        public RSA()
        {
            this.p = 47947;
            this.q = 91577;

            this.publicKey.N = p * q;
            this.publicKey.Key1 = 7;

            this.φn = (p - 1) * (q - 1);

            this.d = ExtendedEuclidean(φn, this.publicKey.Key1);

            this.privateKey.N = p * q;
            this.privateKey.Key1 = d;
        }

        public BigInteger EncryptMessage(BigInteger msg, KeyStruct aPublicKey)
        {
            return ModularExponentation(msg, aPublicKey.Key1, aPublicKey.N);
        }

        public BigInteger DecryptedMsg(BigInteger encryption, KeyStruct aPrivateKey)
        {
            return ModularExponentation(encryption, aPrivateKey.Key1, aPrivateKey.N);
        }

        public BigInteger FindE(BigInteger φn)
        {
            for (BigInteger i = 7; i < φn; i += 2)
            {
                if (gcd(i, φn) == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        public BigInteger gcd(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public BigInteger ModularExponentation(BigInteger msg, BigInteger e, BigInteger n)
        {
            Dictionary<BigInteger, BigInteger> binaryMod = new Dictionary<BigInteger, BigInteger>();
            BigInteger curr_e = 1;
            BigInteger current_msg = msg;
            BigInteger @all_time_e = 1;

            // First get all the mods 
            while (all_time_e < e)
            {
                current_msg = RecursivePower(current_msg, curr_e);
                if (current_msg > n)
                {
                    current_msg = current_msg % n;
                    curr_e = 1;
                }
                binaryMod.Add(all_time_e, current_msg);
                curr_e = curr_e * 2;
                all_time_e = all_time_e * 2;
            }
            all_time_e /= 2;
            BigInteger mod = 1;
            while (e != 0)
            {
                if (e >= all_time_e)
                {
                    mod *= binaryMod[all_time_e];
                    e = e - all_time_e;
                }
                all_time_e /= 2;
            }
            return mod % n;
        }

        public BigInteger RecursivePower(BigInteger msg, BigInteger origonal_e)
        {
            if (origonal_e == 2 || origonal_e == 1)
            {
                return BigInteger.Pow(msg, (int)origonal_e);
            }
            return RecursivePower(msg, origonal_e - 2);
        }

        public BigInteger ExtendedEuclidean(BigInteger a, BigInteger b)
        {
            BigInteger originalMod = b;
            BigInteger x = 0, y = 1;    // Coefficients for b
            BigInteger u = 1, v = 0;    // Coefficients for a

            while (a != 0)
            {
                BigInteger q = b / a;    // Quotient
                BigInteger r = b % a;    // Remainder

                BigInteger m = x - u * q; // Update x coefficient
                BigInteger n = y - v * q; // Update y coefficient

                // Update variables for the next iteration
                b = a;
                a = r;
                x = u;
                y = v;
                u = m;
                v = n;
            }
            if (x < 0)
            {
                x += originalMod; // Adjust to be positive
            }
            return x;
        }
    }
}

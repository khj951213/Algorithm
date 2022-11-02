using System.Security.Cryptography;
using System.Text;

namespace SecurityUtility;
public class HashUtil
{
    public static string ComputeMD5(string input)
    {
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hashBytes = MD5.Create().ComputeHash(inputBytes);
        return Convert.ToHexString(hashBytes);
    }

    public static string ComputeSHA256(string input)
    {
        byte[] inputByte = Encoding.UTF8.GetBytes(input);
        byte[] hashByte = SHA256.Create().ComputeHash(inputByte);
        return Convert.ToHexString(hashByte);
    }
}


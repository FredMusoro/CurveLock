using System.Text;
using Sodium;

namespace CurveLock.Core
{
  public static class KeyGeneration
  {
    public static KeyPair ScryptGenerateKey(string email, string password)
    {
      var salt = GenericHash.Hash(email, (byte[])null, 32);
      var seed = PasswordHash.ScryptHashBinary(Encoding.UTF8.GetBytes(password), salt, PasswordHash.Strength.Moderate);
      var key = PublicKeyBox.GenerateKeyPair(seed);

      return key;
    }

    public static string EncodePublicKey(byte[] publicKey)
    {
      var version = new byte[] { 0x0A };
      return Base58Check.Base58CheckEncoding.Encode(ArrayHelpers.ConcatArrays(version, publicKey));
    }
  }
}

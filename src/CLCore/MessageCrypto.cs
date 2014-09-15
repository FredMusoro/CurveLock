using System;
using System.IO;
using Sodium;

namespace CurveLock.Core
{
  public static class MessageCrypto
  {
    public static byte[] EncryptMessage(byte[] message, string toId)
    {
      //generate an ephemeral key to encrypt this with
      var key = Sodium.PublicKeyBox.GenerateKeyPair();

      //TODO: Check to make sure that the ID version is 0x0A
      var recip = ArrayHelpers.SubArray(Base58Check.Base58CheckEncoding.Decode(toId), 1);

      var nonce = Sodium.SodiumCore.GetRandomBytes(24);
      var encrypted = Sodium.PublicKeyBox.Create(message, nonce, key.PrivateKey, recip);
      var recipVerifier = Sodium.GenericHash.Hash(ArrayHelpers.ConcatArrays(nonce, key.PublicKey), null, 16);
      var version = new byte[] { 0x00 };

      var final = ArrayHelpers.ConcatArrays(version, nonce, key.PublicKey, recipVerifier, encrypted);

      return final;
    }

    public static byte[] DecryptMessage(byte[] message, byte[] privateKey)
    {
      const int VERSION_LENGTH = 1;
      const int NONCE_LENGTH = 24;
      const int SENDER_KEY_LENGTH = 32;
      const int RECIP_VERIFIER_LENGTH = 16;

      var version = ArrayHelpers.SubArray(message, 0, VERSION_LENGTH)[0];
      byte[] ret;

      switch (version)
      {
        case 0x00:
          var nonce = ArrayHelpers.SubArray(message, 1, NONCE_LENGTH);
          var senderKey = ArrayHelpers.SubArray(message, 25, SENDER_KEY_LENGTH);
          var verifier = ArrayHelpers.SubArray(message, 57, RECIP_VERIFIER_LENGTH);
          var encrypted = ArrayHelpers.SubArray(message, 73);

          var decrypted = Sodium.PublicKeyBox.Open(encrypted, nonce, privateKey, senderKey);
          ret = decrypted;

          break;
        default:
          //TODO: Unsupported version
          throw new NotImplementedException();
      }

      return ret;
    }

    public static string EncryptFile(string path, string toId)
    {
      //generate an ephemeral key to encrypt this with
      var key = Sodium.PublicKeyBox.GenerateKeyPair();

      //TODO: Check to make sure that the ID version is 0x0A
      var recip = ArrayHelpers.SubArray(Base58Check.Base58CheckEncoding.Decode(toId), 1);

      var ret = StreamCryptor.StreamCryptor.EncryptFileWithStream(key, recip, path, null, ".CurveLock");

      return ret;
    }

    public static string DecryptFile(string file, KeyPair key)
    {
      var path = Path.GetDirectoryName(file);
      var ret = StreamCryptor.StreamCryptor.DecryptFileWithStream(key, file, path);

      return ret;
    }
  }
}

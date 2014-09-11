using System.Text;
using CurveLock.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sodium;

namespace Tests
{
  /// <summary>
  ///This is a test class for MessageCryptoTest and is intended
  ///to contain all MessageCryptoTest Unit Tests
  ///</summary>
  [TestClass()]
  public class MessageCryptoTest
  {
    /// <summary>
    ///A test for DecryptMessage
    ///</summary>
    [TestMethod()]
    public void DecryptMessageTest()
    {
      var message = Base58Check.Base58CheckEncoding.Decode("1AtPS411ipfcRmvBe1hoSvAbJpNfpvpzKrQHTuK8jw9WTGf69FM7kmkDxhf9nFpfG4dbEgrxYMuyyR3x4LM8LbscDx3x5mQWmGL8cDCShJKFBeEqN688QfhGNVVTsKqWNUJ");
      var privateKey = Utilities.HexToBinary("4ba8e0b41fc07b5a1d4e0be0a4b464f6f2673a3854f967b5c31102b15683a195");
      var expected = Encoding.UTF8.GetBytes("bob");
      var actual = MessageCrypto.DecryptMessage(message, privateKey);

      CollectionAssert.AreEqual(expected, actual);
    }

    /// <summary>
    ///A test for EncryptMessage
    ///</summary>
    [TestMethod()]
    public void EncryptMessageTest()
    {
      var message = Encoding.UTF8.GetBytes("bob");
      const string TO_ID = "Lqm2Foa9keELvGf8cYHJB3CRzEgPLuxJnBdtbZRbhuGmx3dhQB";
      var expected = Encoding.UTF8.GetBytes("bob");
      var encrypted = MessageCrypto.EncryptMessage(message, TO_ID);

      var actual = MessageCrypto.DecryptMessage(encrypted, 
        Utilities.HexToBinary("4ba8e0b41fc07b5a1d4e0be0a4b464f6f2673a3854f967b5c31102b15683a195"));

      CollectionAssert.AreEqual(expected, actual);
    }
  }
}
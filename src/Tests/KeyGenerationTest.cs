using CurveLock.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sodium;

namespace Tests
{
  /// <summary>
  ///This is a test class for KeyGenerationTest and is intended
  ///to contain all KeyGenerationTest Unit Tests
  ///</summary>
  [TestClass()]
  public class KeyGenerationTest
  {
    /// <summary>
    ///A test for EncodePublicKey
    ///</summary>
    [TestMethod()]
    public void EncodePublicKeyTest()
    {
      var publicKey = Utilities.HexToBinary("34f066fa6957e569848e7d6d1faaa129fe43e7bb6b4047e1db34d4e09a9f4e51");
      const string EXPECTED = "Lqm2Foa9keELvGf8cYHJB3CRzEgPLuxJnBdtbZRbhuGmx3dhQB";

      var actual = KeyGeneration.EncodePublicKey(publicKey);

      Assert.AreEqual(EXPECTED, actual);
    }

    /// <summary>
    ///A test for ScryptGenerateKey
    ///</summary>
    [TestMethod()]
    public void ScryptGenerateKeyTest()
    {
      const string EMAIL = "bob@example.com";
      const string PASSWORD = "bobIsGreat&1337!&sTuFf";
      var expected = new KeyPair(
        Utilities.HexToBinary("34f066fa6957e569848e7d6d1faaa129fe43e7bb6b4047e1db34d4e09a9f4e51"), 
        Utilities.HexToBinary("4ba8e0b41fc07b5a1d4e0be0a4b464f6f2673a3854f967b5c31102b15683a195"));

      //this may fail due to needing to allocate 1GB of RAM
      var actual = KeyGeneration.ScryptGenerateKey(EMAIL, PASSWORD);
      CollectionAssert.AreEqual(expected.PrivateKey, actual.PrivateKey);
    }
  }
}
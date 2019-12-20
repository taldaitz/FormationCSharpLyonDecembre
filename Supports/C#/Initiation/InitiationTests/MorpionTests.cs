using Microsoft.VisualStudio.TestTools.UnitTesting;
using Initiation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Initiation.Tests
{
    [TestClass()]
    public class MorpionTests : Morpion
    {
        string userInput;

        public override string GetUserInput()
        {
            return userInput;
        }

        [TestMethod()]
        public void GetCoupTest()
        {
            userInput = "1,1";
            CollectionAssert.AreEqual(new int[] { 1, 1 }, this.GetCoup(), "test 0 : Les coordonnées sont justes et sans espaces");
            userInput = "     1,1";
            CollectionAssert.AreEqual(new int[] { 1, 1 }, this.GetCoup(), "test 1 : Les coordonnées sont justes et avec des espaces devant");
            userInput = "1,1                 ";
            CollectionAssert.AreEqual(new int[] { 1, 1 }, this.GetCoup(), "test 2 : Les coordonnées sont justes et avec des espaces derriere");
            userInput = "   1  , 1   ";
            CollectionAssert.AreEqual(new int[] { 1, 1 }, this.GetCoup(), "test 3 : Les coordonnées sont justes et avec des espaces un peu partout");
            userInput = "a,1";
            CollectionAssert.AreEqual(null, this.GetCoup(), "test 4 : valeur non numérique");
            userInput = "1 1";
            CollectionAssert.AreEqual(null, this.GetCoup(), "test 5 : valeur sans séparateur");
        }

        #region Test paramètres multiples
        [TestMethod()]
        [DataRow("1,1", new int[] { 1, 1 }, DisplayName = "test 0 : Les coordonnées sont justes et sans espaces")]
        [DataRow("     1,1", new int[] { 1, 1 }, DisplayName = "test 1 : Les coordonnées sont justes et avec des espaces devant")]
        [DataRow("1,1                 ", new int[] { 1, 1 }, DisplayName = "test 2 : Les coordonnées sont justes et avec des espaces derriere")]
        [DataRow("   1  , 1   ", new int[] { 1, 1 }, DisplayName = "test 3 : Les coordonnées sont justes et avec des espaces un peu partout")]
        [DataRow("a,1", null, DisplayName = "test 4 : valeur non numérique")]
        [DataRow("1 1", null, DisplayName = "test 5 : valeur sans séparateur")]
        public void GetCoupTest2(string valueInput, int[] expected)
        {
            userInput = valueInput;
            CollectionAssert.AreEqual(expected, this.GetCoup());
        }
        #endregion

        #region Avec Moq
        [TestMethod()]
        [DataRow("1,1", new int[] { 1, 1 }, DisplayName = "test 0 : Les coordonnées sont justes et sans espaces")]
        [DataRow("     1,1", new int[] { 1, 1 }, DisplayName = "test 1 : Les coordonnées sont justes et avec des espaces devant")]
        [DataRow("1,1                 ", new int[] { 1, 1 }, DisplayName = "test 2 : Les coordonnées sont justes et avec des espaces derriere")]
        [DataRow("   1  , 1   ", new int[] { 1, 1 }, DisplayName = "test 3 : Les coordonnées sont justes et avec des espaces un peu partout")]
        [DataRow("a,1", null, DisplayName = "test 4 : valeur non numérique")]
        [DataRow("1 1", null, DisplayName = "test 5 : valeur sans séparateur")]
        public void GetCoupForMockTest2(string valueInput, int[] expected)
        {
            var morpionGame = new Mock<Morpion>();
            morpionGame.Setup(o => o.GetUserInput()).Returns(valueInput);
            CollectionAssert.AreEqual(expected, morpionGame.Object.GetCoup());
        }
        #endregion

        //public void GetCoupForMockTestFake(string valueInput, int[] expected)
        //{
        //    using (ShimsContext.Create())
        //    {
        //        System.ShimConsole.ReadLine = () => valueInput;
        //        var morpionGame = new Morpion();
        //        CollectionAssert.AreEqual(expected, morpionGame.GetCoup());
        //    }
        //}
    }
}
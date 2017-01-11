using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumbyGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExpectedObjects;
using FluentAssertions;
namespace SumbyGroup.Tests
{
    [TestClass()]
    public class SumByGroupTests
    {
        private static List<Item> _source = new List<Item>();

        [TestInitialize()]
        public void MyTestInitialize()
        {
            _source.Add(new Item { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            _source.Add(new Item { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            _source.Add(new Item { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            _source.Add(new Item { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            _source.Add(new Item { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            _source.Add(new Item { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            _source.Add(new Item { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            _source.Add(new Item { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            _source.Add(new Item { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            _source.Add(new Item { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            _source.Add(new Item { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            _source.Clear();
        }

        [TestMethod()]
        public void CalculatSumTest_以Cost欄位為主並且三個為一組_6_15_24_21()
        {

            //arrange
            var target = new SumByGroup();
            var expected = new List<int>() { 6, 15, 24, 21 };

            //act

            var result = target.CalculatSum<Item>(_source, 3, t => t.Cost);
            //assert
            expected.ToExpectedObject().ShouldEqual(result);

        }

        [TestMethod()]
        public void CalculateSumTest_以Revenuex欄位為主並且四個為一組_50_66_60()
        {
            //arrange
            var target = new SumByGroup();
            var expected = new List<int>() { 50, 66, 60 };

            //act
            var result = target.CalculatSum<Item>(_source, 4, t => t.Revenue);

            //assert
            expected.ToExpectedObject().ShouldEqual(result);
        }

        [TestMethod()]
        public void CalculateSumTest_傳入Null物件會例外錯誤()
        {
            //arrange
            var target = new SumByGroup();
            List<int> exptected = new List<int>();

            
            Action act = () => target.CalculatSum<Item>(_source, 3, t => t.Cost);
            act.ShouldNotThrow<ArgumentOutOfRangeException>();
        }
    }
}
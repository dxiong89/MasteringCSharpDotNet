using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockRepository;
using MockRepository.Interface;
using POCO;
using POCO.Enums;

namespace MasteringCSharpDotNet.LINQ
{
    [TestClass]
    public class Linq
    {
        //Better Comments
        //Use '!' for Important.
        //Use '?' for Question.
        //Use "Todo" (Case ignored) for Task.
        //Use 'x', 'X', or double comment for strikethrough(Crossed).

        StudentRepo studentRepo = new StudentRepo();
        List<Student> collection;

        [TestInitialize]
        public void Initialize()
        {
            collection = studentRepo.GetStudents();
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void FilteringStudentsWhoAreAge15()
        {
            List<Student> filteredCollection = collection.Where(e => e.age == 15).ToList();
            Assert.AreEqual(filteredCollection.Count, 2);
        }

        // ! test
        // 
        [TestMethod]
        public void QueryStudentsWhoAreAge15AndReturnFirstName()
        {
            var filteredCollection = collection.Where(x => x.age == 15).Select(x => x.firstName).ToList();
            Assert.AreEqual(filteredCollection.Count, 2);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void QueryStudentsWhoAreAge15AndReturnObject()
        {
            var filteredCollection = collection.Where(x => x.age == 13).Select(x => new { x.firstName, x.lastName, x.gender }).ToList();
            Assert.AreEqual(filteredCollection.Count, 3);
        }
    }
}

using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.INFRA.Services
{
    public class TestmonialService : ITestmonialService
    {
        private readonly ITestmonialRepoisitory testmonialRepoisitory ;
        public TestmonialService(ITestmonialRepoisitory testmonialRepoisitory)
        {
            this.testmonialRepoisitory = testmonialRepoisitory;
        }
        public bool DeleteTestmonial(int id)
        {
            return testmonialRepoisitory.DeleteTestmonial(id);
        }

        public List<Testmonial> GetAllTestmonials()
        {
            return testmonialRepoisitory.GetAllTestmonials();
        }

        public Testmonial GetTestemonialById(int id)
        {
            return testmonialRepoisitory.GetTestemonialById(id);
        }

        public bool InsertTestemonial(Testmonial testmonial)
        {
            return testmonialRepoisitory.InsertTestemonial(testmonial);
        }

        public bool UpdateTestmonial(Testmonial testmonial)
        {
            return testmonialRepoisitory.UpdateTestmonial(testmonial);
        }
    }
}

using Auction.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auction.LMS.CORE.Repoisitory
{
   public interface ITestmonialRepoisitory
    {
        public List<Testmonial> GetAllTestmonials();

        public bool InsertTestemonial(Testmonial testmonial );
        public bool UpdateTestmonial(Testmonial testmonial );
        public bool DeleteTestmonial(int id);
        public Testmonial GetTestemonialById(int id);
    }
}

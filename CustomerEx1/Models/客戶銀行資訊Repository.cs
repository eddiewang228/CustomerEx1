using System;
using System.Linq;
using System.Collections.Generic;
	
namespace CustomerEx1.Models
{   
	public  class 客戶銀行資訊Repository : EFRepository<客戶銀行資訊>, I客戶銀行資訊Repository
	{
        public IQueryable<客戶銀行資訊> All(bool isAll = false)
        {
            if (isAll)
            {
                return base.All();
            }
            return base.All().OrderByDescending(p => p.Id).Where(p => p.Delmark == false);
        }

        public 客戶銀行資訊 Find(int id)
        {
            return this.All().FirstOrDefault(p => p.Id == id);
        }

       
        public override void Delete(客戶銀行資訊 entity)
        {
            entity.Delmark = true;
        }
    }

	public  interface I客戶銀行資訊Repository : IRepository<客戶銀行資訊>
	{

	}
}
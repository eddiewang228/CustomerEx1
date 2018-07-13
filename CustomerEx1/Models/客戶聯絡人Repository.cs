using System;
using System.Linq;
using System.Collections.Generic;
	
namespace CustomerEx1.Models
{   
	public  class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
	{
        public IQueryable<客戶聯絡人> All(bool isAll = false)
        {
            if (isAll)
            {
                return base.All();
            }
            return base.All().OrderByDescending(p => p.Id).Where(p => p.Delmark == false);
        }

        public 客戶聯絡人 Find(int id)
        {
            return this.All().FirstOrDefault(p => p.Id == id);
        }

      
        public override void Delete(客戶聯絡人 entity)
        {
            entity.Delmark = true;
        }
    }

	public  interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
	{

	}
}
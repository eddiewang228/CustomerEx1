using System;
using System.Linq;
using System.Collections.Generic;
	
namespace CustomerEx1.Models
{
   

    public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{
        public IQueryable<客戶資料> All(bool isAll = false)
        {
            if (isAll)
            {
                return base.All();
            }
            return base.All().OrderByDescending(p => p.Id).Where(p => p.Delmark == false);
        }

        public 客戶資料 Find(int id)
        {
            return this.All().FirstOrDefault(p => p.Id == id);
        }

        public IQueryable<客戶資料> 搜尋名稱(string keyword)
        {
            var 客戶資料 = this.All();

            if (!String.IsNullOrEmpty(keyword))
            {
                客戶資料 = 客戶資料.Where(p => p.客戶名稱.Contains(keyword));
            }

            return 客戶資料;
        }
        public override void Delete(客戶資料 entity)
        {
            entity.Delmark = true;
        }
    }

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}
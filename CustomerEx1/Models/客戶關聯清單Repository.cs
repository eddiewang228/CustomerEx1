using System;
using System.Linq;
using System.Collections.Generic;
	
namespace CustomerEx1.Models
{   
	public  class 客戶關聯清單Repository : EFRepository<客戶關聯清單>, I客戶關聯清單Repository
	{

	}

	public  interface I客戶關聯清單Repository : IRepository<客戶關聯清單>
	{

	}
}
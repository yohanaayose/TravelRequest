using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRequest.Model;

namespace TravelRequest.Core
{
   public class SaveData
    {
            public static MyContext myContext = new MyContext();

            public SaveData(MyContext _myContext)
            {
                myContext = _myContext;
            }

            public SaveData()
            {

            }

            public bool Save(MyContext myContext)
            {
                bool status;
                var result = myContext.SaveChanges();
                if (result > 0)
                {
                    status = true;
                    Console.WriteLine("Save Success");
                }
                else
                {
                    status = false;
                    Console.WriteLine("Save Failed");

                }
                return status;
            }
        }
    }

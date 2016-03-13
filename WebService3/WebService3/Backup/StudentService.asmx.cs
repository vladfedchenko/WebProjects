using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Collections.Generic;

namespace WebService3
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class StudentService : System.Web.Services.WebService
    {

        [WebMethod]
        public Student[] GetStudentsWithMakrHigherThan(Student[] input, double mark)
        {
            List<Student> ret = new List<Student>();
            foreach (Student stud in input)
            {
                if (stud.AverageMark >= mark)
                    ret.Add(stud);
            }

            return ret.ToArray();
        }

        [WebMethod]
        public string HelloWorld() 
        {
            return "Hello World!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temporary
{
    class Program
    {
        string forename, surname, academic_prog;
        int idnum;
        public static void display(string forename, string surname, string academic_prog, int idnum)
        {
            this.forename = forename;
            this.surname = surname;
            this.academic_prog = academic_prog;
            this.idnum = idnum;
        }
	}
    public static void main(String[] args)
    {
        Program ss;
        ss.forename = "Viral";
        ss.surname = "Joshi";
        ss.academic_prog = "Mobile Solution Developer";
        ss.idnum = 7780919;
        ss.display();
    }
} 

    }
}

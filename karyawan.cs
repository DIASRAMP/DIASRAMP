using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemprograman2908
{
    class karyawan
    {   
        public karyawan(string name, int no, int nik, int gaji)
        {
            Name=name;
            No=no;
			Nik=nik;
			Gaji=gaji;
        }

        public string Name{get; set;}
        public int No{get; set;}
		public int Nik{get; set;}
		public int Gaji{get; set;}
		

        public void gaji()
        {
            Console.WriteLine("karyawan has name : {0} No : {1} Nik : {2} Gaji : {3}  ", Name,No,Nik,Gaji);
		}
		
	    public void gajinaik ()
		{
			Console.WriteLine("karyawan has name : {0} No : {1} Nik : {2} Gaji : {3}  ", Name,No,Nik,Gaji+(Gaji*10/100));
		}

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace nhom_9
{
    [Serializable]
    internal class DanhSachDatLich
    {
       private List<DatLich> _danhSachDatLich;
        public DanhSachDatLich()
        {
            _danhSachDatLich = new List<DatLich>();
        }
        public List<DatLich> danhSachDatLich
        {
            get { return this._danhSachDatLich.ToList(); }
            set {this._danhSachDatLich = value; }
        }
        public void AddDanhSachDatLich(DatLich dsdt)
        {
            this._danhSachDatLich.Add(dsdt);
        }
        public int tao_ID(DatLich datlich)
        {
            int id=0 ;
            foreach (DatLich d in this._danhSachDatLich)
                id++;
            return id;
        }
        public bool timTG(DatLich dl)
        {
            foreach(DatLich d in this._danhSachDatLich)
            {
                if(d.thoigian.Equals(dl.thoigian))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

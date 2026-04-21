using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Db_ci
{
    #region Anggota
    public class Anggota
    {
        #region Member Variables
        protected int _id_anggota;
        protected string _nomor_anggota;
        protected string _nama;
        protected string _alamat;
        protected string _telepon;
        protected string _email;
        protected unknown _tanggal_daftar;
        #endregion
        #region Constructors
        public Anggota() { }
        public Anggota(string nomor_anggota, string nama, string alamat, string telepon, string email, unknown tanggal_daftar)
        {
            this._nomor_anggota=nomor_anggota;
            this._nama=nama;
            this._alamat=alamat;
            this._telepon=telepon;
            this._email=email;
            this._tanggal_daftar=tanggal_daftar;
        }
        #endregion
        #region Public Properties
        public virtual int Id_anggota
        {
            get {return _id_anggota;}
            set {_id_anggota=value;}
        }
        public virtual string Nomor_anggota
        {
            get {return _nomor_anggota;}
            set {_nomor_anggota=value;}
        }
        public virtual string Nama
        {
            get {return _nama;}
            set {_nama=value;}
        }
        public virtual string Alamat
        {
            get {return _alamat;}
            set {_alamat=value;}
        }
        public virtual string Telepon
        {
            get {return _telepon;}
            set {_telepon=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        public virtual unknown Tanggal_daftar
        {
            get {return _tanggal_daftar;}
            set {_tanggal_daftar=value;}
        }
        #endregion
    }
    #endregion
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradeFirmLib
{
    public enum Rights
    {
        Read,
        Write,
        Admin,
        Guest
    }
    public class Account
    {
        [Key]
        [ForeignKey("Employee")]
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public Rights Right { get; set; }
        public string Login { get; }
        public string Password { get; set; }
        public bool ActiveFlag { get; set; }
        public Account(Employee Employee, Rights Right)
        {
            this.Right = Right;
            this.Login = CreateLogin(Employee);
            this.ActiveFlag = true;
            this.Password = CreatePassword();
        }
        private string CreateLogin(Employee emp) => emp.Name.Split(' ').First() + "_" + emp.Id;
        private string CreatePassword(string password = "12345678") => EncryptPassword(password);
        private string EncryptPassword(string password) 
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            return Encoding.UTF8.GetString(byteHash);
        }
        public void ChangePassword(string newPsw) => Password = EncryptPassword(newPsw);
        public bool VerifyUser(string login, string password)
        {
            if (EncryptPassword(password).Equals(Password) && Login.Equals(login))
            {
                return true;
            }
            return false;
        }
    }
}

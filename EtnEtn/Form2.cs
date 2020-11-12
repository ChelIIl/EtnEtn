using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtnEtn
{
    public partial class Form2 : Form
    {
        private Contract Contract { get; }
        private bool IsShown { get; }
        private Car Car = new Car();
        private Person Person = new Person(); 

        public Form2(Contract contract)
        {
            InitializeComponent();
            this.IsShown = false;
            this.Contract = contract;
            if (contract.Id != 0)
            {
                this.Fill();
            }
        }

        private void Fill()
        {
            this.fname_t.Text = this.Contract.Person1.FName;
            this.sname_t.Text = this.Contract.Person1.LName;
            this.pname_t.Text = this.Contract.Person1.PName;
            this.email_t.Text = this.Contract.Person1.EMail;
            this.phone_t.Text = this.Contract.Person1.Phone;
            this.birth_t.Value = this.Contract.Person1.BirthDate;

            this.mark_t.Text = this.Contract.Car1.Mark;
            this.price_num.Value = this.Contract.Car1.Price;
            this.mile_t.Value = this.Contract.Car1.Mileage;
            this.issue_date.Value = this.Contract.Car1.IssueYear;
            this.v_t.Text = this.Contract.Car1.Size;
            this.desc_t.Text = this.Contract.Car1.Description;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Contract.Id <= 0)
                {
                    this.Person.FName = this.fname_t.Text;
                    this.Person.LName = this.sname_t.Text;
                    this.Person.PName = this.pname_t.Text;
                    this.Person.EMail = this.email_t.Text;
                    this.Person.Phone = this.phone_t.Text;
                    this.Person.BirthDate = this.birth_t.Value;
                    DBConnection.Entities.People.Add(this.Person);

                    this.Car.Mark = this.mark_t.Text;
                    this.Car.Price = this.price_num.Value;
                    this.Car.Mileage = Convert.ToInt32(this.mile_t.Value);
                    this.Car.IssueYear = this.issue_date.Value;
                    this.Car.Size = this.v_t.Text;
                    this.Car.Description = this.desc_t.Text;
                    DBConnection.Entities.Cars.Add(this.Car);

                    this.Contract.ConDate = DateTime.Today;
                    this.Contract.Car = this.Car.IdCar;
                    this.Contract.Person = this.Person.IdPerson;
                    DBConnection.Entities.Contracts.Add(this.Contract);
                }

                DBConnection.Entities.SaveChanges();
                MessageBox.Show("Данные схранены");

                this.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Некорректно введены данные");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (this.Contract.Id > 0)
            {
                DBConnection.Entities.Contracts.Remove(this.Contract);
                DBConnection.Entities.SaveChanges();
            }

            MessageBox.Show("Данные схранены");
            this.Close();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            try
            {
                this.Contract.Person1.FName = this.fname_t.Text;
                this.Contract.Person1.LName = this.sname_t.Text;
                this.Contract.Person1.PName = this.pname_t.Text;
                this.Contract.Person1.EMail = this.email_t.Text;
                this.Contract.Person1.Phone = this.phone_t.Text;
                this.Contract.Person1.BirthDate = this.birth_t.Value;

                this.Contract.Car1.Mark = this.mark_t.Text;
                this.Contract.Car1.Price = this.price_num.Value;
                this.Contract.Car1.Mileage = Convert.ToInt32(this.mile_t.Value);
                this.Contract.Car1.IssueYear = this.issue_date.Value;
                this.Contract.Car1.Size = this.v_t.Text;
                this.Contract.Car1.Description = this.desc_t.Text;

                DBConnection.Entities.SaveChanges();

                MessageBox.Show("Данные схранены");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Некорректно введены данные");
            }
        }
    }
}

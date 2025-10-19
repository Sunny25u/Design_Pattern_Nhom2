using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DPM225407_NguyenHuuDuy_MyWord_18_Memento
{
    public class SalesProspect
    {
        private string name = null!;
        private string phone = null!;
        private double budget;
        // Gets or sets name
        public string Name
        {
            get => name;
            set
            {
                name = value;
                WriteLine("Name:   " + name);
            }
        }
        // Gets or sets phone
        public string Phone
        {
            get => phone;
            set
            {
                phone = value;
                WriteLine("Phone:  " + phone);
            }
        }
        // Gets or sets budget
        public double Budget
        {
            get => budget;
            set
            {
                budget = value;
                WriteLine("Budget: " + budget);
            }
        }
        // Stores (serializes) memento
        public Memento SaveMemento()
        {
            WriteLine("\nSaving state --\n");
            var memento = new Memento();
            return memento.Serialize(this);
        }
        // Restores (deserializes) memento
        public void RestoreMemento(Memento memento)
        {
            WriteLine("\nRestoring state --\n");
            var s = (SalesProspect)memento.Deserialize();
            Name = s.Name;
            Phone = s.Phone;
            Budget = s.Budget;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Projekt_kurier
{
    public enum PackageState { Posted, Assigned, Delivered, Cancelled }
    public class Package : INotifyPropertyChanged
    {
        public User Sender { get; set; }
        public string RecipientName { get; set; }
        public string RecipientSurname { get; set; }
        public string RecipientAddress { get; set; }
        public string Description { get; set; }
        public Courier AssignedCourier { get; set; }
        public PackageState State { get; set; }

        public Package() { }
        public Package(User sender, string recipientname, string recipientsurname, string recipientaddress, string description)
        {
            Sender = sender;
            RecipientName = RecipientName;
            RecipientSurname = recipientsurname;
            RecipientAddress = recipientaddress;
            Description = description;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public override string ToString()
        {
            return "Od: " + Sender.UserName + " " + Sender.UserSurname + " do: " + RecipientSurname + " " + RecipientName + " " + RecipientAddress + "\t" + State.ToString();
        }
    }
}

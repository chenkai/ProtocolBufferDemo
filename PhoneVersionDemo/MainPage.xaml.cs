using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneVersionDemo.Resources;

using ProtoBuf;
using ProtoBuf.ServiceModel;

namespace PhoneVersionDemo
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Loaded+=MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //Build First Entity Model
            var defineCustomer = new CustomerInfo()
            {
                Id = 1208,
                Address = "BeiJing JingQun Road 23Tower",
                CustomerName = new CustomerName() {  FirstName="Jack", SecondName="chen"}
            };

        }
    }

    [ProtoContract]
    public class CustomerInfo
    {
        [ProtoMember(1)]
        public int Id { get; set; }
        [ProtoMember(2)]
        public CustomerName CustomerName { get; set; }
        [ProtoMember(3)]
        public string Address { get; set; }
    }

    [ProtoContract]
    public class CustomerName
    {
        [ProtoMember(1)]
        public string FirstName { get; set; }
        [ProtoMember(2)]
        public string SecondName { get; set; }
    }
}
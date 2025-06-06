﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample
{
    public class OrderInfoRepository
    {
        private ObservableCollection<OrderInfo> orderInfo;
        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; }
        }

        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        public void GenerateOrders()
        {
            orderInfo.Add(new OrderInfo("1001", "Maria Anders", "Germany", "ALFKI", "Berlin"));
            orderInfo.Add(new OrderInfo("1002", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F."));
            orderInfo.Add(new OrderInfo("1003", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F."));
            orderInfo.Add(new OrderInfo("1004", "Thomas Hardy", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo("1005", "Tim Adams", "Sweden", "BERGS", "London"));
            orderInfo.Add(new OrderInfo("1006", "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo("1007", "Andrew Fuller", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo("1008", "Martin King", "Spain", "BOLID", "Madrid"));
            orderInfo.Add(new OrderInfo("1009", "Lenny Lin", "France", "BONAP", "Marsiella"));
            orderInfo.Add(new OrderInfo("1010", "John Carter", "Canada", "BOTTM", "Lenny Lin"));
            orderInfo.Add(new OrderInfo("1011", "Laura King", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo("1012", "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo("1013", "Martin King", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo("1014", "Gina Irene", "UK", "AROUT", "London"));
        }

        public void ChangeCollection()
        {
            orderInfo.Add(new OrderInfo("2001", "Selena Alvarad", "Sweden", "BERGS", "London"));
            orderInfo.Add(new OrderInfo("2002", "Sandra Altamirano", "Mexico", "ANATR", "Mexico D.F."));
            orderInfo.Add(new OrderInfo("2003", "Oscar Alpuerto", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo("2004", "Cecil Allison", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo("2005", "Tim Adams", "Germany", "ALFKI", "Berlin"));
            orderInfo.Add(new OrderInfo("2006", "Michael Allen", "Canada", "BOTTM", "Lenny Lin"));
            orderInfo.Add(new OrderInfo("2007", "Andrew Fuller", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo("2008", "Martin King", "Spain", "BOLID", "Madrid"));
            orderInfo.Add(new OrderInfo("2009", "Phyllis Allen", "France", "BONAP", "Marsiella"));
            orderInfo.Add(new OrderInfo("2010", "John Carter", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo("2011", "Marvin Allen", "Sweden", "BERGS", "London"));
            orderInfo.Add(new OrderInfo("2012", "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo("2013", "Sean Jacobson", "Mexico", "ANTON", "Mexico D.F."));
            orderInfo.Add(new OrderInfo("2014", "Gina Irene", "UK", "AROUT", "London"));
        }
    }
}

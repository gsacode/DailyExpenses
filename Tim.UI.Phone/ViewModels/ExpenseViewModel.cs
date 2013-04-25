using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Tim.UI.Phone.Model;

namespace Tim.UI.Phone.ViewModels
{
    public class ExpenseViewModel : INotifyPropertyChanged
    {
        #region Fields
        private int _expenseId;
        /// <summary>
        /// Expense Identifier
        /// </summary>
        /// <returns></returns>
        public int ExpenseId
        {
            get
            {
                return _expenseId;
            }
            set
            {
                if (value != _expenseId)
                {
                    _expenseId = value;
                    NotifyPropertyChanged("ExpenseId");
                }
            }
        }

        private string _title;
        /// <summary>
        /// Title for the expense
        /// </summary>
        /// <returns></returns>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value != _title)
                {
                    _title = value;
                    NotifyPropertyChanged("Title");
                }
            }
        }

        private double _amount;
        /// <summary>
        /// Amount of the Expense
        /// </summary>
        /// <returns></returns>
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                if (value != _amount)
                {
                    _amount = value;
                    NotifyPropertyChanged("Amount");
                }
            }
        }
        #endregion

        #region INotifyPropertyChanged Methods
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region CRUD
        public int CreateExpense(string Title, int Amount)
        {
            var connection = new Connection();
            return connection.DbConn.Insert(new Expense() { Title = Title, Amount = Amount });
        }
        #endregion
    }
}
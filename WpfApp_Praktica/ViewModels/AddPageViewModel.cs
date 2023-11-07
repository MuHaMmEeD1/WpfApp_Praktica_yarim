using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_Praktica.Models;

namespace WpfApp_Praktica.ViewModels
{
    public class AddPageViewModel
    {
        public Person Person { get; set; }

        public AddPageViewModel(Person person)
        {
            this.person = person;
        }

        public Person person { get; set; }




    }
}

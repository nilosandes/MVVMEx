using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMEx.ViewModels
{
    public class AutoViewModel : Models.Auto
    {
        Models.Auto _auto = new Models.Auto
        {
            manufacturer = "Oldsmobile",
            model = "Cutlas Supreme",
            color = "Silver",
            year = 1988
        };

        public AutoViewModel()
        {
            this.manufacturer = _auto.manufacturer;
            this.model = _auto.model;
            this.color = _auto.color;
            this.year = _auto.year;
        }
    }
}

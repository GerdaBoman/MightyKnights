using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ParkingSpotCosmetic
{
    public class ParkingLotSpaces
    {
        public void ParkingLotSize( int capacity, FlowLayoutPanel flowPanel)
        {
            for(int i = 1; i <= capacity; i++)
            {
                Button b = new Button();
                b.Text= i.ToString();
                b.Name= "pSpot"+ i.ToString();
                b.Size= new Size( 45,60);
                b.BackColor = Color.FromArgb(89, 165, 216);

                flowPanel.Controls.Add(b);
                
            }
        }
    }
}

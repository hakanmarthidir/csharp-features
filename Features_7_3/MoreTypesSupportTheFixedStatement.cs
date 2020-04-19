using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Features_7_3
{
    //Fixed yapısı artık daha fazla tipe destek vermektedir. 
    //Fixed ile yaratılan nesnenin bir ögesinin memory uzerindeki alanını sabitleriz. GB tarafından yer degisikliklerine karsı koruma yaratmış oluruz. 
    //7.3 ile birlikte artık daha fazla type a destek vermektedir. 

    class MoreTypesSupportTheFixedStatement
    {
        public MoreTypesSupportTheFixedStatement()
        {
            unsafe {

                MyCar mycar = new MyCar();
                
                fixed (int* speedPointer = &mycar.CarSpeed)
                {
                    *speedPointer = 120;
                    Console.WriteLine(mycar.CarSpeed);
                }            
            }
        }
    }

    public class MyCar
    {
        public int CarSpeed;
    }
}

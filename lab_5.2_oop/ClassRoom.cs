using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5._2_oop
{
    class ClassRoom
    {
        public void  Pupil1(Pupil x, Pupil y)
        {
            x.Study();
            y.Write();
        }
        public void Pupil2(Pupil x,Pupil y, Pupil z)
        {
            x.Write();
            y.Relax();
            z.Study();
        }
         public void Pupil3(Pupil x,Pupil y)
        {
            x.Read();
            y.Relax();
        }
        public void Pupil4(Pupil x, Pupil y, Pupil z)
        {
            x.Study();
            y.Write();
            z.Relax();
        }
    }
}

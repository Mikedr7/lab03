using System;

namespace ClassLibrary2
{
    public class Pupil
    {
        public Pupil() { }
        public virtual void Study()
        {
            Console.WriteLine("Pupil studies");
        }
        public virtual void Read()
        {
            Console.WriteLine("Pupil reads");
        }
        public virtual void Write()
        {
            Console.WriteLine("Pupil writes");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Pupil relaxes");
        }

    }
    public class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcellentPupil studies excellent");
        }
        public override void Read()
        {
            Console.WriteLine("ExcellentPupil reads excellent");
        }
        public override void Write()
        {
            Console.WriteLine("ExcellentPupil writes excellent");
        }
        public override void Relax()
        {
            Console.WriteLine("ExcellentPupil relaxes less");
        }
    }
    public class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil studies good");
        }
        public override void Read()
        {
            Console.WriteLine("GoodPupil reads good");
        }
        public override void Write()
        {
            Console.WriteLine("GoodPupil writes good");
        }
        public override void Relax()
        {
            Console.WriteLine("GoodPupil relaxes a little bit");
        }
    }
    public class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil studies bad");
        }
        public override void Read()
        {
            Console.WriteLine("BadPupil reads bad");
        }
        public override void Write()
        {
            Console.WriteLine("BadPupil writes bad");
        }
        public override void Relax()
        {
            Console.WriteLine("BadPupil relaxes a lot");
        }
    }
    public class ClassRoom
    {
        public ClassRoom() { }
        private Pupil[] pupils;
        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length != 4)
            {
                throw new ArgumentException("Quantity of pupil must be 4\n");
            }
            else
            {
                this.pupils = pupils;
            }
        }
        public void ShowInfo()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine($"\n-----------------------------\nStatistic of pupil №{i + 1}:");
                Console.WriteLine("Studying: ");
                pupils[i].Study();
                Console.WriteLine("Reading: ");
                pupils[i].Read();
                Console.WriteLine("Writing: ");
                pupils[i].Write();
                Console.WriteLine("Relaxing: ");
                pupils[i].Relax();
            }
        }
    }

}
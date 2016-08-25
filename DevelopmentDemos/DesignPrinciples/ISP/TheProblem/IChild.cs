namespace DesignPrinciples.ISP.TheProblem
{
    /// <summary>
    /// Interface Segregation Priciple
    /// The problem: Fat Interfaces. Meaning, interfaces that are too over populated with un relavent operations that when concerete classes inherit from, 
    /// causes these classes to have methods that are not relevant and not used
    /// </summary>
    public interface IChild
    {
        void Eat();
        void Sleep();
        void Cry();
        void Play();
        void GoToSchool();
        void GoToNursery();
        void Crawl();
        void Walk();
    }

    public class Baby : IChild
    {
        public void Eat()
        {
            //Yes I Eat
        }

        public void Sleep()
        {
            //Yes I Sleep
        }

        public void Cry()
        {
            //Yes I Cry
        }

        public void Play()
        {
            //I Cant Play yet
        }

        public void GoToSchool()
        {
            //I cant go to school yet
        }

        public void GoToNursery()
        {
            //I cant go to nursey yet
        }

        public void Crawl()
        {
            //Yes I Crawl
        }

        public void Walk()
        {
            // I cant walk
        }
    }

    public class Toddler : IChild
    {
        public void Eat()
        {
            //Yes I Eat
        }

        public void Sleep()
        {
            //Yes I Sleep
        }

        public void Cry()
        {
            //Yes I Cry
        }

        public void Play()
        {
            //Yes I Play
        }

        public void GoToSchool()
        {
            //No, I cant go to school yet
        }

        public void GoToNursery()
        {
            //Yes im old enough now
        }

        public void Crawl()
        {
            //No, i dont crawl anymore
        }

        public void Walk()
        {
            //I can walk
        }
    }

    public class Preschooler: IChild
    {
        public void Cry()
        {
            //Dont really cry anymore
        }

        public void Eat()
        {
            //Yes I Eat
        }

        public void GoToNursery()
        {
            //No i dont go to nursery
        }

        public void Crawl()
        {
            //No i dont crawl any more
        }

        public void Walk()
        {
            //I can walk
        }

        public void GoToSchool()
        {
            //Yes I go to school now
        }

        public void Play()
        {
            //Yes i can play
        }

        public void Sleep()
        {
            //Yesi can sleep
        }
    }
}

using System;

namespace DesignPrinciples.ISP.TheSolution
{
    /// <summary>
    /// The Solution: Interfaces should try to be small, and client specific. Meaning that concrete classes can inherit from multiple smaller and relevant interfaces
    /// instead of one large non specific interface
    /// </summary>
    public interface IChild
    {
        void Eat();
        void Sleep();
        void Cry();
    }

    public interface IBaby
    {
        void Crawl();
    }
    

    public interface IToddler : IPlayable, IWalkable
    {
        void GoToNursery();
    }

    public interface IPreSchooler : IPlayable, IWalkable
    {
        void GoToSchool();
    }

    public interface IWalkable
    {
        void Walk();
    }

    public interface IPlayable
    {
        void Play();
    }

    public class Baby : IChild, IBaby
    {
        public void Eat()
        {
            //Yes I Eat
        }

        public void Sleep()
        {
            //Yes i Sleep
        }

        public void Cry()
        {
            //Yes I cry
        }

        public void Crawl()
        {
            //Yes I Crawl
        }
    }

    public class Toddler : IChild, IToddler
    {
        public void Eat()
        {
            //Yes I Eat
        }

        public void Sleep()
        {
            //Yes i Sleep
        }

        public void Cry()
        {
            //Yes I cry
        }

        public void GoToNursery()
        {
            //Yes i GoToNusery
        }

        public void Play()
        {
            //Yes i Play
        }

        public void Walk()
        {
            //Yes i can walk
        }
    }

    public class PreSchooler : IChild, IPreSchooler
    {
        public void Eat()
        {
            //Yes I Eat
        }

        public void Sleep()
        {
            //Yes i Sleep
        }

        public void Cry()
        {
            //Yes i Cry
        }

        public void GoToSchool()
        {
            //Yes i GoToShcool
        }

        public void Play()
        {
            //Yes i Play too
        }

        public void Walk()
        {
            //Yes i can walk
        }
    }



}

using System;

namespace GameOverrideDemo
{
    public class Skill
    {
        protected string skillName;
        protected float basePower;
        protected float manaCost;

        public Skill()
        {
            skillName = "Basic Skill";
            basePower = 10f;
            manaCost = 5f;
            Console.WriteLine("----> Konstruktor default Skill <----");
        }

        public Skill(string name, float power, float cost)
        {
            Console.WriteLine("----> Konstruktor berparameter Skill <----");
            skillName = name;
            basePower = power;
            manaCost = cost;
        }

        public virtual float CalculateDamage()
        {
            Console.WriteLine("[Skill.CalculateDamage] Menghitung damage dasar...");
            return basePower;
        }

        public void DisplaySkillInfo()
        {
            Console.WriteLine("SKILL NAME    : " + skillName);
            Console.WriteLine("BASE POWER    : " + basePower);
            Console.WriteLine("MANA COST     : " + manaCost);
        }
    }
}

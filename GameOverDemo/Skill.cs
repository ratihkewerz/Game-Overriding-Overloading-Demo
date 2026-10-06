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
            basePower = 10 ;
            manaCost = 5 ;
            Console.WriteLine("----> Konstruktor Default Skill <----");
        }

        public Skill(string name, float power, float cost)
        {
            Console.WriteLine("----> Konstruktor Berparameter Skill <----");
            skillName = name;
            basePower = power;
            manaCost = cost;
        }

        public virtual float CalculateDamage()
        {
            Console.WriteLine("[Skill.CalculateDamage] Menghitung damage dasar...");
            return basePower;
        }

        public float CalculateDamage(float multiplier)
        {
            Console.WriteLine($"[Skill.CalculateDamage] Menghitung damage dengan multiplier: {multiplier}");
            return basePower * multiplier;
        }

        public float CalculateDamage(float multiplier, float targetDefense)
        {
            Console.WriteLine($"[Skill.CalculateDamage] Menghitung damage dengan multiplier {multiplier} dan defense {targetDefense}");
            float damage = basePower * multiplier;
            damage -= targetDefense * 0.5f;
            if (damage < 0) damage = 0;
            return damage;
        }

        public float CalculateDamage(string damageType)
        {
            Console.WriteLine($"[Skill.CalculateDamage] Menghitung damage tipe: {damageType}");
            float damage = basePower;
            if (damageType == "Piercing")
                damage *= 1.3f;
            else if (damageType == "Blunt")
                damage *= 1.1f;
            return damage;    
        }

        public void DisplaySkillInfo()
        {
            Console.WriteLine("SKILL NAME    : " + skillName);
            Console.WriteLine("BASE POWER    : " + basePower);
            Console.WriteLine("MANA COST     : " + manaCost);
        }
    }
}
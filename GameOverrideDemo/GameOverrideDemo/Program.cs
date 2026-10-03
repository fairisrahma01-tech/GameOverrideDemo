 namespace GameOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO OVERRIDING (GAME SKILLS) ===\n");


            Console.WriteLine("1. Membuat physicalSkill");
            PhysicalSkill slash = new PhysicalSkill(0.3f, "slash", 50f, 15f);
            slash.DisplaySkillInfo();
            float slashDamage = slash.CalculateDamage();
            Console.WriteLine("Damage yang dihasilkan: " + slashDamage + "\n");

            Console.WriteLine("2. Membuat MAgicSkill");
            MagicSkill fireball = new MagicSkill("Fire", "Fireball", 40f, 25f);
            fireball.DisplaySkillInfo();
            float fireDamage = fireball.CalculateDamage();
            Console.WriteLine("DAmage yang dihasilkan: " + fireDamage + "\n");

            Console.WriteLine("3. Membuat HealSKill");
            HealSkill heal = new HealSkill(30f, "Heal", 50f, 20f);
            heal.DisplaySkillInfo();
            float healAmount = heal.CalculateDamage();
            Console.WriteLine("Healing yang dihasilkan: " + healAmount + "\n");

            Console.ReadKey();
        }
    }
}

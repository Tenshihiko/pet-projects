namespace Zanzarah
{
    public class MemoryDatabase :IDatabase
    {
        private readonly Repo _repo = new Repo();


        public Effectiveness GetEffectiveness(Element attacker, Element victim)
        {
            try
            {
                return _repo.EffectivenessTable[attacker][victim];
            }
            catch
            {
                return Effectiveness.Neutral;
            }
        }
    }
}

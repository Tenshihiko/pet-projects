namespace Zanzarah
{
    interface IDatabase
    {
        Effectiveness GetEffectiveness(Element attaccker, Element victim);
    }
}

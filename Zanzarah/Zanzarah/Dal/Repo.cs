using System.Collections.Generic;

namespace Zanzarah
{
    public class Repo
    {
        public Dictionary<Element, Dictionary<Element, Effectiveness>> EffectivenessTable = new Dictionary<Element, Dictionary<Element, Effectiveness>>(){
            {Element.Nature, new Dictionary<Element, Effectiveness>()
                {
                    {Element.Psi, Effectiveness.Effective},
                    {Element.Ice, Effectiveness.Ineffective},
                    {Element.Fire, Effectiveness.Ineffective},
                    {Element.Dark, Effectiveness.Ineffective},
                    {Element.Chaos, Effectiveness.Effective},
                    {Element.Metal, Effectiveness.Ineffective},
                }
            },
        };
    }
}